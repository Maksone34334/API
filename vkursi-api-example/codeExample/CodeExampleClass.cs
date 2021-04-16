﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using vkursi_api_example.estate;
using vkursi_api_example.organizations;

namespace vkursi_api_example.codeExample
{
    public class CodeExampleClass
    {
        // Приклад отримання списку пов'язаних з компанією бенеціціарів, керівників, адрес, власників пакетів акцій
        public void GetRelationsCodeExample(string token)
        {
            // Читаемо перелік кодів ЄДРПОУ з файлу
            List<string> QueryUserId = new List<string>();

            using (var sr = new StreamReader(@"C:\Users\user\Downloads\relationIdList.txt"))
            {
                string textLine = string.Empty;

                while ((textLine = sr.ReadLine()) != null)
                {
                    // textLine = textLine.PadLeft(8, '0');
                    QueryUserId.Add(textLine);
                }
            }

            // Шлях до файлу в який буде саписано результат
            DirectoryInfo filePath = new DirectoryInfo(@"C:\Users\user\Downloads");

            List<string> TextLineList = new List<string>();

            int count = 0;

            foreach (var item in QueryUserId)
            {
                count++;
                if ((count % 100) == 0)
                {
                    Console.Write("\b\b\b\b\b\b\b{0}", count);
                    // Записуемо в файл по 100 записів
                    WriteOneLineToTxt(TextLineList, filePath, "ClientsState.txt");
                    TextLineList.Clear();
                }

                GetRelationsResponseModel GRResponse = GetRelationsClass.GetRelations(ref token, item, null);

                if (GRResponse != null && GRResponse.Data != null)
                {
                    //foreach (var itemData in GRResponse.Data)
                    //{
                    //    string textLine = item +
                    //        "\t" + itemData.Id +
                    //        "\t" + itemData.DirectionIn +
                    //        "\t" + itemData.Type +
                    //        "\t" + itemData.Name +
                    //        "\t" + itemData.Edrpou;

                    //    TextLineList.Add(textLine);
                    //}
                }
                else
                {

                }
            }
            // Записуемо решту в файл
            WriteOneLineToTxt(TextLineList, filePath, "ClientsState.txt");
        }

        // Запис в файл
        public static bool WriteOneLineToTxt(List<string> TextLineist, DirectoryInfo filePath, string fileName)
        {
            try
            {
                FileStream stream = new FileStream(filePath + @"\" + fileName, FileMode.Append, FileAccess.Write);

                using (StreamWriter sw = new StreamWriter(stream))
                {
                    foreach (var item in TextLineist)
                    {
                        sw.WriteLine(item);
                    }
                    sw.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        // Приклад отримання скорочених даних ДЗК за списком кадастрових номерів

        public static void GetPKKUinfo(string token)
        {
            List<string> FileTextLineList = new List<string>();

            using (var sr = new StreamReader(@"C:\Users\vadim\Desktop\cadNumb.txt"))
            {
                string textLine = string.Empty;

                while ((textLine = sr.ReadLine()) != null)
                {
                    FileTextLineList.Add(textLine?.Trim());
                }

                FileTextLineList = FileTextLineList.Distinct().ToList();
            }

            int count = 0;

            List<string> CadNumberList = new List<string>();

            List<KadastrMapApiDetailsEstate> KadastrMapApiDetails = new List<KadastrMapApiDetailsEstate>();

            foreach (var item in FileTextLineList)
            {
                count++;

                CadNumberList.Add(item);

                if ((count % 99) == 0 || count == FileTextLineList.Count)
                {
                    GetPKKUinfoResponseModel GetPKKUinfoResponse = GetPKKUinfoClass.GetPKKUinfo(ref token, CadNumberList);
                    CadNumberList.Clear();

                    KadastrMapApiDetails.AddRange(GetPKKUinfoResponse.Data);
                }
            }

            using (var writer = new StreamWriter(@"C:\Users\vadim\Desktop\cadNumbResult.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(KadastrMapApiDetails);
            }

            Console.WriteLine();
        }
    }
}
