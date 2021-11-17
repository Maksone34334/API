<h2>Перелік методів Vkusi API:</h2>
<br>

<h3>1. Авторизація (отримання токена авторизації)</h3>

<p><b>Дані методу: </b>Токен авторизації</p>

<pre><code>curl --location --request POST 'https://vkursi-api.azurewebsites.net/api/1.0/token/authorize' \
        --header 'Content-Type: application/json' \
        --data-raw '{"email":"test@testemail.com","password":"123456qwert"}'
</code></pre>

<p><i>* Вкажіть ваш логін та пароль від сервісу vkursi.pro які ви вводиди при реєстрации облікового запису vkursi.pro/account/register</i></p>

<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/token/AuthorizeClass.cs" target="_blank">[POST] /api/1.0/token/authorize</a></p>

<p><b>Модель відповіді: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/token/AuthorizeClass.cs#L81" target="_blank">AuthorizeResponseModel</a></p>

<p><b>Приклад відповіді: </b> <a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/responseExample/AuthorizeResponse.json" target="_blank">AuthorizeResponse.json</a></p>

<br>
<br>

<h3>2. Запит на отримання скорочених даних по організаціям за кодом ЄДРПОУ</h3>

<p><b>Дані методу: </b>Назва організації, Код ЄДРПОУ, ПІБ Керівника, Статус реєстрації, Дані про реєстрацію платником ПДВ, Наявний податковий борг, Наявні санкції, Наявні виконавчі провадження, Express score, Відомості про платника ЄП</p>

<pre><code>curl --location --request POST 'https://vkursi-api.azurewebsites.net/api/1.0/organizations/getorganizations' \
        --header 'ContentType: application/json' \
        --header 'Authorization: Bearer eyJhbGciOiJIUzI1Ni...' \
        --header 'Content-Type: application/json' \
        --data-raw '{"code": ["40073472"]}'</code></pre>

<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrganizationsClass.cs" target="_blank">[POST] /api/1.0/organizations/getorganizations</a></p>

<p><b>Модель відповіді: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrganizationsClass.cs#L118" target="_blank">GetOrganizationsResponseModel</a></p>

<p><b>Приклад відповіді: </b> <a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/responseExample/GetOrganizationsResponse.json" target="_blank">GetOrganizationsResponse.json</a></p>

<br>
<br>

<h3>3. Запит на отримання коротких даних по ФОП за кодом ІПН</h3>

<p><b>Дані методу: </b>ПІБ ФОП-а, Код, Статус реєстрації, Дані про реєстрацію платником ПДВ, Наявний податковий борг, Наявні санкції, Наявні виконавчі провадження, Express score, Відомості про платника ЄП</p>

<pre><code>curl --location --request POST 'https://vkursi-api.azurewebsites.net/api/1.0/organizations/getfops' \
        --header 'ContentType: application/json' \
        --header 'Authorization: Bearer eyJhbGciOiJI...' \
        --header 'Content-Type: application/json' \
        --data-raw '{"code": ["3334800417"]}'</code></pre>

<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetFopsClass.cs" target="_blank">[POST] /api/1.0/organizations/getfops</a></p>

<p><b>Модель відповіді: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetFopsClass.cs#L96" target="_blank">GetFopsResponseModel</a></p>

<p><b>Приклад відповіді: </b> <a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/responseExample/GetFopsResponse.json" target="_blank">GetFopsResponse.json</a></p>

<br>
<br>

<h3>4. Реєстраційні дані мінюсту онлайн. Запит на отримання розширених реєстраційних даних по юридичним або фізичним осіб за кодом ЄДРПОУ / ІПН</h3>

<p><b>Дані методу: </b>Повні реєстраційні дані по фізичній / юридичній особі: Назва, ЄДРПОУ / ІПН, Дата реєстрації, Адреса, КВЕДи, Засновники, Бенефіціари, Правонаступники, Керівники, Підписанти, Дані про розмір статутного капіталу, Контактні дані, Дані про перебування юридичної особи в процесі провадження у справі про банкрутство, санації, Дата та номер запису про державну реєстрацію припинення</p>

<pre><code>curl --location --request POST 'https://vkursi-api.azurewebsites.net/api/1.0/organizations/getadvancedorganization' \
        --header 'ContentType: application/json' \
        --header 'Authorization: Bearer eyJhbGciOiJIUzI1Ni...' \
        --header 'Content-Type: application/json' \
        --data-raw '{"Code":"21560045"}'</code></pre>
        
<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetAdvancedOrganizationClass.cs" target="_blank">[POST] /api/1.0/organizations/getadvancedorganization</a></p>

<p><b>Модель відповіді: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetAdvancedOrganizationClass.cs#L121" target="_blank">GetAdvancedOrganizationResponseModel</a></p>

<p><b>Приклад відповіді: </b> <a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/responseExample/GetAdvancedOrganizationResponse.json" target="_blank">GetAdvancedOrganizationResponse.json</a></p>

<br>
<br>

<h3>5. Отримання відомостей про наявні об'єкти нерухоммого майна у фізичних та юридичних осіб за кодом ЄДРПОУ або ІПН</h3>

<p><b>Дані методу: </b>Перелік об'єктів нерухомого майна(об'єкти нерухомого майна, зелельні ділянки), Тип речового права (Інше право, Власність, Іпотека, Обтяження), Роль суб’єкта (Власник, Орендар, Іпотекодержатель, Правонабувач, ...), Адреса, Площа ділянки, Тип власності, Координати, Цільове призначення</p>

<pre><code>curl --location --request GET 'https://vkursi-api.azurewebsites.net/api/1.0/estate/getestatebycode?code=3080213038' \
        --header 'ContentType: application/json' \
        --header 'Authorization: Bearer eyJhbGciOiJIUzI1...' \
        --header 'Content-Type: application/json' \</pre></code>
        
<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/GetEstateByCodeClass.cs" target="_blank">[GET] /api/1.0/estate/getestatebycode</a></p>

<p><b>Модель відповіді: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/GetEstateByCodeClass.cs#L114" target="_blank">GetRealEstateRightsResponseModel</a></p>

<p><b>Приклад відповіді: </b> <a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/responseExample/GetRealEstateRightsResponse.json" target="_blank">GetRealEstateRightsResponse.json</a></p>

<br>
<br>

<h3>6. Отримати дані щоденного моніторингу по компаніям які додані на моніторинг (стрічка користувача)</h3>

<p><b>Дані методу: </b>Опис інформації по змінам які відбулись по суб'єкту (ЮО/ФОП/ФО/ОНМ), Дата зміни, Найменування суб'єкта, Тип зміни, Тип (1 - організация | 2 - фізична особа, ..), Id списку</p>

<pre><code>curl --location --request GET 'https://vkursi-api.azurewebsites.net/api/1.0/changes/getchanges?date=28.10.2019' \
        --header 'ContentType: application/json' \
        --header 'Authorization: Bearer eyJhbGciOiJI...' \</pre></code>

<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/changes/GetChangesClass.cs" target="_blank">[GET] /api/1.0/changes/getchanges</a></p>

<p><b>Модель відповіді: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/changes/GetChangesClass.cs#L98" target="_blank">GetChangesResponseModel</a></p>

<p><b>Приклад відповіді: </b> <a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/responseExample/GetChangesResponse.json" target="_blank">GetChangesResponse.json</a></p>

<br>
<br>

<h3>7. Отримати перелік списків (які користувач створив на vkursi.pro/eventcontrol#/reestr). Списки в сервісі використовуються для зберігання контрагентів, витягів та довідок</h3>

<p><b>Дані методу: </b>Назва списку, Id списку</p>

<pre><code>curl --location --request GET 'https://vkursi-api.azurewebsites.net/api/1.0/monitoring/getallreestr' \
        --header 'ContentType: application/json' \
        --header 'Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cC...' \
        --header 'Content-Type: application/json' \</pre></code>
        
<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/monitoring/GetAllReestrClass.cs" target="_blank">[GET] /api/1.0/monitoring/getAllReestr</a></p>

<p><b>Модель відповіді: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/monitoring/GetAllReestrClass.cs#L94" target="_blank">GetAllReestrResponse</a></p>

<p><b>Приклад відповіді: </b> <a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/responseExample/GetAllReestrResponse.json" target="_blank">GetAllReestrResponse.json</a></p>

<br>
<br>

<h3>8. Додати новий список контрагентів (список також можливо створити з інтерфейсу на сторінці vkursi.pro/eventcontrol#/reestr). Списки в сервісі використовуються для зберігання контрагентів, витягів та довідок</h3>

<p><b>Дані методу: </b>Id списку новостворенного списку</p>

<pre><code>curl --location --request POST 'https://vkursi-api.azurewebsites.net/api/1.0/monitoring/addNewReestr' \
        --header 'Content-Type: application/json' \
        --header 'Authorization: Bearer  eyJhbGciOiJIUzI1NiIsInR...' \
        --data-raw '{"reestrName":"Назва нового реєстру"}'</pre></code>
        
<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/monitoring/AddNewReestrClass.cs" target="_blank">[POST] /api/1.0/monitoring/addNewReestr</a></p>

<p><b>Приклад відповіді: </b>"453449dc-9288-4bb6-9831-754485173339"</p>

<br>
<br>

<h3>9. Запит на отримання аналітичних даних по організації за кодом ЄДРПОУ</h3>

<p><b>Дані методу: </b>Аналіз тендерів в розрізі період, Патенти, торгові марки, Аналітика по деклараціям, Загальна аналітика по судовим рішенням, Аналітика по справам призначенним до розгляду в розрізі місяця, Виконавчі провадження, Публікації ВГСУ про банкрутство, Аналітика по Edata, Аналітика по перевіркам, Динаміка податкового боргу, Історія реєстрацийних змін, Аналіз ліцензій, Дані експрес перевірки, Відомості про наявні санкції, Аналітика по засновникам в розрізі країни, Фінансова аналітика, Аналіз участі в тендерах в розрізі CPV, Аналіз земельних ділянок, Аналіз об'єктів нерухомого майна, Аналіз ЗЕД, Аналіз фінансових ризиків, Дані про кількість співробітників</p>

<pre><code>curl --location --request POST 'https://vkursi-api.azurewebsites.net/api/1.0/organizations/getanalytic' \
        --header 'ContentType: application/json' \
        --header 'Authorization: Bearer eyJhbGciOiJIUzI1Ni...' \
        --header 'Content-Type: application/json' \
        --data-raw '{"code":"00131305"}'</pre></code>
        
<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetAnalyticClass.cs" target="_blank">[POST] /api/1.0/organizations/getanalytic</a></p>

<p><b>Модель відповіді: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetAnalyticClass.cs#L122" target="_blank">GetAnalyticResponseModel</a></p>

<p><b>Приклад відповіді: </b> <a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/responseExample/GetAnalyticResponse.json" target="_blank">GetAnalyticResponse.json</a></p>

<br>
<br>

<h3>10. Запит на отримання переліку судових документів організації за критеріями: Тип сторони (Позивач, Відповідач, Інша сторона), Фора судочинства (Цивільне, Кримінальне, Господарське, Адміністративне, Адмінправопорушення), За статтями НПА (закони, кодекси, ...)(контент та параметри документа э можливість отримати в методі /api/1.0/courtdecision/getdecisionbyid)</h3>

<p><b>Дані методу: </b>Id документа, Дата судового документу</p>

<pre><code>curl --location --request POST 'https://vkursi-api.azurewebsites.net/api/1.0/courtdecision/getdecisions' \
        --header 'ContentType: application/json' \
        --header 'Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cC...' \
        --header 'Content-Type: application/json' \
        --data-raw '{"Edrpou":"14360570","Skip":0,"TypeSide":null,"JusticeKindId":null,"Npas":["F545D851-6015-455D-BFE7-01201B629774"]}'</pre></code>
        
<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/courtdecision/GetDecisionsClass.cs" target="_blank">[POST] /api/1.0/courtdecision/getdecisions</a></p>

<p><b>Модель відповіді: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/courtdecision/GetDecisionsClass.cs#L129" target="_blank">GetDecisionsResponseModel</a></p>

<p><b>Приклад відповіді: </b> <a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/responseExample/GetDecisionsResponse.json" target="_blank">GetDecisionsResponse.json</a></p>

<br>
<br>

<h3>11. Запит на отримання контенту судового рішення за id документа (id документа можна отримати в api/1.0/courtdecision/getdecisions)</h3>

<p><b>Дані методу: </b>Контент судового документа</p>

<pre><code>curl --location --request POST 'https://vkursi-api.azurewebsites.net/api/1.0/courtdecision/getcontent' \
        --header 'ContentType: application/json' \
        --header 'Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5c...' \
        --header 'Content-Type: application/json' \
        --data-raw '"84583482"'</pre></code>
        
<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/courtdecision/GetContentClass.cs" target="_blank">[POST] /api/1.0/courtdecision/getcontent</a></p>

<br>
<br>

<h3>12. Додати контрагентів до списку (до списку vkursi.pro/eventcontrol#/reestr)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/monitoring/AddToControlClass.cs" target="_blank">[POST] /api/1.0/Monitoring/addToControl</a></p>

ddToControlClass.AddToControl("00131305", "1c891112-b022-4a83-ad34-d1f976c60a0b", token);

<br>
<br>

<h3>13. Видалити контрагентів зі списку</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/monitoring/RemoveFromControlClass.cs" target="_blank">[POST] /api/1.0/Monitoring/removeFromControl</a></p>

RemoveFromControlClass.RemoveFromControl("00131305", "1c891112-b022-4a83-ad34-d1f976c60a0b", token);

<br>
<br>

<h3>14. Отримання переліку кодів ЄДРПОУ або Id фізичних або юридичних осіб які знаходятся за певним КОАТУУ</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetInfoByKoatuuClass.cs" target="_blank">[POST] /api/1.0/organizations/getinfobykoatuu</a></p>

GetInfoByKoatuuClass.GetInfoByKoatuu("510900000", "1", token);

<br>
<br>

<h3>15. Новий бізнес. Запит на отримання списку новозареєстрованих фізичних та юридичних осіб</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetNewRegistrationClass.cs" target="_blank">[POST] /api/1.0/organizations/getnewregistration</a></p>

GetNewRegistrationClass.GetNewRegistration("29.10.2019", "1", 0, 10, true, true, token);

<br>
<br>

<h3>16. Видалити список контрагентів</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/monitoring/RemoveReestrClass.cs" target="_blank">[DELETE] /api/1.0/monitoring/removeReestr</a></p>

RemoveReestrClass.RemoveReestr("1c891112-b022-4a83-ad34-d1f976c60a0b", token);

<br>
<br>

<h3>17. Отримати перелік компаний які відібрані в модулі BI</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/bi/GetBiDataClass.cs" target="_blank">[POST] /api/1.0/bi/getbidata</a></p>

GetBiDataClass.GetBiData(null, 1000, token);
// New
GetDataBiInfoClass.GetDataBiInfo("1c891112-b022-4a83-ad34-d1f976c60a0b", 1000, DateTime.Parse("2019-11-28 19:00:52.059"), token);
// New 
GetDataBiChangeInfoClass.GetDataBiChangeInfo(DateTime.Parse("2019-11-28 19:00:52.059"), "1c891112-b022-4a83-ad34-d1f976c60a0b", false, 100, token);
// New
GetDataBiOrganizationInfoClass.GetDataBiOrganizationInfo(new List<string> { "1c891112-b022-4a83-ad34-d1f976c60a0b" }, new List<string> { "00131305" }, token);

<br>
<br>

<h3>18. Отримати перелік Label доступних в модулі BI</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/bi/GetBiImportLabelsClass.cs" target="_blank">[GET] /api/1.0/bi/getbiimportlabels</a></p>

GetBiImportLabelsClass.GetBiImportLabels(token);
// New
GetBiLabelsClass.GetBiLabels(token);

<br>
<br>

<h3>19. Отримання інформації з ДРРП, НГО, ДЗК + формування звіту по земельним ділянкам</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/EstateTaskApiClass.cs" target="_blank">[POST] /api/1.0/estate/estatecreatetaskapi</a></p>

EstateTaskApiClass.EstateCreateTaskApi(token);

<br>
<br>

<h3>20. Отримання інформації створені задачі (задачі на виконання запитів до ДРРП, НГО, ДЗК)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/EstateTaskApiClass.cs" target="_blank">[GET] /api/1.0/estate/getestatetasklist</a></p>

EstateTaskApiClass.GetEstateTaskList(token);

<br>
<br>

<h3>21. Отримання інформації про виконання формування звіту та запитів до ДРРП, НГО, ДЗК за TaskId</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/EstateTaskApiClass.cs" target="_blank">[POST] /api/1.0/estate/estategettaskdataapi</a></p>

EstateTaskApiClass.EstateGetTaskDataApi(token, "taskId", "7424955100:04:001:0511");

<br>
<br>

<h3>22. ДРОРМ отримання скороченных данных по ІПН / ЄДРПОУ</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/movableloads/GetMovableLoadsClass.cs" target="_blank">[POST] /api/1.0/movableLoads/getmovableloads</a></p>

GetMovableLoadsClass.GetMovableLoads(token, "36679626", "1841404820");

<br>
<br>

<h3>23. ДРОРМ отримання витяга</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/movableloads/GetPayMovableLoadsClass.cs" target="_blank">[POST] /api/1.0/MovableLoads/getpaymovableloads</a></p>

GetPayMovableLoadsClass.GetPayMovableLoads(token, 17374040);

<br>
<br>

<h3>24. ДРРП отримання скороченных данных по ІПН / ЄДРПОУ</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/GetEstatesClass.cs" target="_blank">[POST] /api/1.0/estate/GetEstates</a></p>

GetEstatesClass.GetEstates(token, "36679626", null);

<br>
<br>

<h3>25. Отримання повного витяга з реєстру нерухомого майна (ДРРП)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/GetAdvancedRrpReportClass.cs" target="_blank">[POST] /api/1.0/estate/getadvancedrrpreport</a></p>

GetAdvancedRrpReportClass.GetAdvancedRrpReport(token, 5001466269723, 68345530);

<br>
<br>

<h3>26. Рекізити судового документа</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/courtdecision/GetDecisionByIdClass.cs" target="_blank">[POST] /api/1.0/courtdecision/getdecisionbyid</a></p>

GetDecisionByIdClass.GetDecisionById("88234097", token);

<br>
<br>

<h3>27. Обьем ресурсів доспупних користувачу відповідно до тарифного плану</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/token/GetTariffClass.cs" target="_blank">[GET] /api/1.0/token/gettariff</a></p>

GetTariffClass.GetTariff(token);

<br>
<br>

<h3>28. Метод АРІ, який віддає історію по компанії з можливістю обрати період.</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/changes/GetChangesByCodeClass.cs" target="_blank">[POST] /api/1.0/changes/getchangesbyCode</a></p>

GetChangesByCodeClass.GetChangesByCode(token, "00131305", "20.11.2018", "25.11.2019", null);

<br>
<br>

<h3>29. Отримання інформації по фізичній особі</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/person/CheckPersonClass.cs" target="_blank">[POST] /api/1.0/person/checkperson</a></p>

CheckPersonClass.CheckPerson(token, "ШЕРЕМЕТА ВАСИЛЬ АНАТОЛІЙОВИЧ", "2301715013");

<br>
<br>

<h3>30. ДРОРМ отримання витягів які були замовлені раніше в сервісі Vkursi</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/movableloads/GetExistedMovableloadsClass.cs" target="_blank">[POST] /api/1.0/movableloads/getexistedmovableloads</a></p>

<br>
<br>

<h3>31. Основні словники сервісу</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/dictionary/GetDictionaryClass.cs" target="_blank">[POST] /api/1.0/dictionary/getdictionary</a></p>

GetDictionaryClass.GetDictionary(ref token, 0);

<br>
<br>

<h3>32. Інформація про наявний авто транспорт за кодом ІПН / ЄДРПОУ</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgVehicleClass.cs" target="_blank">[POST] /api/1.0/organizations/getorgvehicle</a></p>

GetOrgVehicleClass.GetOrgVehicle(ref token, "00131305");

<br>
<br>

<h3>33. Список виконавчих проваджень по фізичним або юридичним особам за кодом ІПН / ЄДРПОУ</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgEnforcementsClass.cs" target="_blank">[POST] /api/1.0/organizations/getorgenforcements</a></p>

GetOrgEnforcementsClass.GetOrgEnforcements(ref token, "00131305");

<br>
<br>

<h3>34. Загальна статистики по Edata (по компанії)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgPubliicFundsClass.cs" target="_blank">[POST] /api/1.0/organizations/getorgpubliicfunds</a></p>

GetOrgPubliicFundsClass.GetOrgPubliicFunds(ref token, "00131305");

<br>
<br>

<h3>35. Фінансові ризики</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgFinancialRisksClass.cs" target="_blank">[POST] /api/1.0/organizations/getorgFinancialRisks</a></p>

GetOrgFinancialRisksClass.GetOrgFinancialRisks(ref token, "00131305");

<br>
<br>

<h3>36. Перелік декларантів повязаних з компаніями</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetDeclarationsInfoClass.cs" target="_blank">[POST] /api/1.0/organizations/getdeclarationsinfo</a></p>

GetDeclarationsInfoClass.GetDeclarationsInfo(ref token, "00131305");

<br>
<br>

<h3>37. Перелік ліцензій, та дозволів</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgLicensesInfoClass.cs" target="_blank">[POST] /api/1.0/organizations/getorglicensesinfo</a></p>

GetOrgLicensesInfoClass.GetOrgLicensesInfo(ref token, "00131305");

<br>
<br>

<h3>38. Відомості про інтелектуальну власність (патенти, торгові марки, корисні моделі) які повязані по ПІБ з бенефіціарами підприємства</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgIntellectualPropertyClass.cs" target="_blank">[POST] /api/1.0/organizations/getorgintellectualproperty</a></p>

GetOrgIntellectualPropertyClass.GetOrgIntellectualProperty(ref token, "00131305");

<br>
<br>

<h3>39. Відомості про власників пакетів акцій (від 5%)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgShareholdersClass.cs" target="_blank">[POST] /api/1.0/organizations/getorgshareholders</a></p>

GetOrgShareholdersClass.GetOrgShareholders(token, "00131305");

<br>
<br>

<h3>40. Частка державних коштів в доході</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgStateFundsStatisticClass.cs" target="_blank">[POST] /api/1.0/organizations/getorgstatefundsstatistic</a></p>

GetOrgStateFundsStatisticClass.GetOrgStateFundsStatistic(token, "00131305");

<br>
<br>

<h3>41. Отримати список пов'язаних з компанією бенеціціарів, керівників, адрес, власників пакетів акцій</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetRelationsClass.cs" target="_blank">[POST] /api/1.0/organizations/getrelations</a></p>

GetRelationsClass.GetRelations(ref token, "00131305", null);

<br>
<br>

<h3>42. Запит на отримання геопросторових даних ПККУ</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/GetCadastrCoordinatesClass.cs" target="_blank">[POST] /api/1.0/estate/getcadastrcoordinates</a></p>

GetCadastrCoordinatesClass.GetCadastrCoordinates(token, "0521685603:01:004:0001", "geojson");

<br>
<br>

<h3>43. Загальна характеристика по тендерам</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgTenderAnalyticClass.cs" target="_blank">[POST] /api/1.0/organizations/getorgtenderanalytic</a></p>

GetOrgTenderAnalyticClass.GetOrgTenderAnalytic(token, "00131305");

<br>
<br>

<h3>44. Офіційні повідомлення (ЄДР, SMIDA, Банкрутство)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOfficialNoticesClass.cs" target="_blank">[POST] /api/1.0/organizations/getofficialnotices</a></p>

GetOfficialNoticesClass.GetOfficialNotices(token, "00131305");

<br>
<br>

<h3>45. Додати об'єкт до моніторингу нерухомості за номером ОНМ (sms rrp)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/EstatePutOnMonitoringClass.cs" target="_blank">[POST] /api/1.0/estate/estateputonmonitoring</a></p>

EstatePutOnMonitoringClass.EstatePutOnMonitoring(token, "1260724348000");

<br>
<br>

<h3>46. Змінити період моніторингу об'єкта нерухомості за номером ОНМ (sms rrp)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/EstateInCreaseMonitoringPeriodClass.cs" target="_blank">[POST] /api/1.0/estate/estateincreasemonitoringperiod</a></p>

EstateInCreaseMonitoringPeriodClass.EstateInCreaseMonitoringPeriod(token, 1260724348000);

<br>
<br>

<h3>47. Видалити об'єкт з мониторингу (sms rrp)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/EstateRemoveFromMonitoringClass.cs" target="_blank">[POST] /api/1.0/estate/estateremovefrommonitoring</a></p>

EstateRemoveFromMonitoringClass.EstateRemoveFromMonitoring(token, 1260724348000);

<br>
<br>

<h3>48. Отримати зміни по об'єкту шо на мониторингу (можлимо через webhook)</h3>
// [inprogress]

<br>
<br>

<h3>49.Перевірка наявності об'єкта за ОНМ (sms rrp)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/SmsRrpSelectIsRealtyExistsClass.cs" target="_blank">[POST] /api/1.0/estate/SmsRrpSelectIsRealtyExists</a></p>

SmsRrpSelectIsRealtyExistsClass.SmsRrpSelectIsRealtyExists(token, 1260724348000);

<br>
<br>

<h3>51. Судові документі по ЮО/ФО</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/courtdecision/GetStanRozgliaduSpravClass.cs" target="_blank">[POST] api/1.0/CourtDecision/getStanRozgliaduSprav</a></p>

<br>
<br>

<h3>52. Оригінальний метод пошуку нерухомості Nais (короткі дані) </h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/estate/GetEstatesAdvancedSearchClass.cs" target="_blank">[POST] api/1.0/Estate/GetEstatesAdvancedSearch</a></p>

<br>
<br>

<h3>53. Фінансовий моніторинг пов'язаних осіб частина 1. Створення задачі</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/SetTaskCompanyDeclarationsAndCourtsClass.cs" target="_blank">[POST] api/1.0/Organizations/SetTaskCompanyDeclarationsAndCourts</a></p>

<br>
<br>

<h3>54. Фінансовий моніторинг пов'язаних осіб частина 2. Отримуємо результат виконання задачі</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetTaskCompanyDeclarationsAndCourtsClass.cs" target="_blank">[POST] api/1.0/Organizations/GetTaskCompanyDeclarationsAndCourts</a></p>

GetTaskCompanyDeclarationsAndCourtsClass.GetTaskCompanyDeclarationsAndCourts(ref token, Guid.Parse("691e940c-b61e-4feb-ad1f-fa22c365633f"));

<p><b>Приклад відповіді: </b> <a href="https://raw.githubusercontent.com/vkursi-pro/API/master/vkursi-api-example/responseExample/GetTaskCompanyDeclarationsAndCourtsResponse.json" target="_blank">GetTaskCompanyDeclarationsAndCourtsResponse.json</a></p>

<br>
<br>
        
<h3>55. Список виконавчих проваджень по фізичним особам за кодом ІПН</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/person/GetPersonEnforcementsClass.cs" target="_blank">[POST] /api/1.0/person/GetPersonEnforcements</a></p>

<p><b>Дані методу: </b>Дані з реєстру виконавчих проваджень</p>

<pre><code>curl --location --request POST 'https://vkursi-api.azurewebsites.net/api/1.0/person/GetPersonEnforcements' \
        --header 'Authorization: Bearer eyJhbGciOiJIUzI1N...' \
        --header 'Content-Type: application/json' \
        --data-raw '{"Code":"3015301315","LastName":"СТЕЛЬМАЩУК","FirstName":"АНДРІЙ","SecondName":"ВАСИЛЬОВИЧ"}'
</code></pre>

<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/person/GetPersonEnforcementsClass.cs" target="_blank">[POST] /api/1.0/person/GetPersonEnforcements</a></p>

<p><b>Модель відповіді: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/person/GetPersonEnforcementsClass.cs#L154" target="_blank">GetPersonEnforcementsResponseModel </a></p>

<p><b>Приклад відповіді: </b> <a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/responseExample/GetPersonEnforcementsResponse.json" target="_blank">GetPersonEnforcementsResponse.json</a></p>

<br>
<br>
        
<h3>56. Отримання статуту підприємства</h3>
[POST] api/1.0/organizations/GetStatutnuyFileUrl

<br>
<br>
      
<h3>57. Аналіз фінансових показників підприємства за кодом ЄДРПОУ</h3>

GetOrgFinanceClass.GetOrgFinance(ref token, "00131305");
        
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgFinanceClass.cs" target="_blank">[POST] api/1.0/organizations/GetOrgFinance</a></p>

<p><b>Дані методу: </b>фінансові показники діяльності подприємства (баланси, звіти про фінансові результати)</p>

<pre><code>curl --location --request POST 'https://vkursi-api.azurewebsites.net/api/1.0/organizations/GetOrgFinance' \
        --header 'Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI...' \
        --header 'Content-Type: application/json' \
        --data-raw '{"Code":["00131305"]}'
</code></pre>

<p><b>Приклад коду: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgFinanceClass.cs" target="_blank">[POST] /api/1.0/organizations/GetOrgFinance</a></p>

<p><b>Модель відповіді: </b><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgFinanceClass.cs#L110" target="_blank">GetOrgFinanceResponseModel</a></p>

<p><b>Приклад відповіді: </b> <a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/responseExample/GetOrgFinanceResponse.json" target="_blank">GetOrgFinanceResponse.json</a></p>

<br>
<br>
      
<h3>58. Оригинальний метод Nais, на отримання скороченних данних по коду ІПН / ЄДРПОУ </h3>
[POST] /api/1.0/organizations/freenais

FreeNaisClass.FreeNais(ref token, "00131305", "True", "100");

<br>
<br>
      
<h3>59. Оригинальний метод Nais, на отримання повних данних по ЮО або ФОП за кодом ІПН/ЄДРПОУ або кодом NaisId (який ми отримуємо з [POST] /api/1.0/organizations/freenais)</h3>
[GET] /api/1.0/organizations/paynais

PayNaisClass.Paynais(ref token, 811202);

<br>
<br>
      
<h3>59.1 Оригінальний метод Nais, на отримання повних данних по ЮО або ФОП за кодом ІПН/ЄДРПОУ або кодом NaisId (який ми отримуємо з [POST] /api/1.0/organizations/freenais)</h3>
[GET] /api/1.0/organizations/payNaisSign

<br>
<br>
      
<h3>60. Отримання відомостей по Експрес оцінку ризиків у ЮО, ФОП та ФО за ПІБ та кодом ІПН / ЄДРПОУ</h3>
[POST] /api/1.0/organizations/getExpressScore

GetExpressScoreClass.GetExpressScore(ref token, 1, "37199162");

<br>
<br>
      
<h3>61. Редагування відомостей вагу ризиків в Експрес оцінці</h3>
[POST] /api/1.0/organizations/EditExpressScoreWeight?type=1

EditExpressScoreWeightClass.EditExpressScoreWeight(ref token, "[{\"borgZarPlati\":[{\"indicatorValue\":\">=200000\",\"weight\":1},{\"indicatorValue\":\">100000#=<200000\",\"weight\":2},{\"indicatorValue\":\"=<100000\",\"weight\":3}],\"vidkrytiVp\":[{\"indicatorValue\":\">=5\",\"weight\":1},{\"indicatorValue\":\">1#<5\",\"weight\":2},{\"indicatorValue\":\"=0\",\"weight\":3}],}]");

<br>
<br>
      
<h3>62. Отримання відомостей про вагу ризиків в Експрес оцінці</h3>
[POST] /api/1.0/organizations/GetExpressScoreWeight?type=1

GetExpressScoreWeightClass.GetExpressScoreWeight(ref token);

<br>
<br>
      
<h3>63. Структура власності компанії</h3>
[POST] /api/1.0/organizations/GetOwnershipStructure

GetOwnershipStructureClass.GetOwnershipStructure(ref token, "31077508");

<br>
<br>
        
<h3>64. Перелік об'єктів в списках</h3>
[POST] /api/1.0/monitoring/getContent

GetContentMonitoringClass.GetContent(ref token, "31077508" ); // string reestrId

<br>
<br>
      
<h3>65. Отримати скорочені дані ДЗК за списком кадастрових номерів</h3>
[POST] /api/1.0/estate/GetPKKUinfo

GetPKKUinfoClass.GetPKKUinfo(ref token, new List<string> { "5321386400:00:042:0028" });

<br>
<br>
      
<h3>66. Отримати дані реквізитів для створення картки ФОП / ЮО</h3>
[POST] /api/1.0/organizations/GetRequisites

GetRequisitesClass.GetRequisites(ref token, "41462280");

<br>
<br>
      
<h3>67. Запит на отримання повних реквізитів та контенту судових документів організації за критеріями</h3>
[POST] /api/1.0/courtdecision/getdecisionsbyfilter

GetDecisionsByFilterClass.GetDecisionsByFilter("00131305", 0, 1, 2, new List<string>() { "F545D851-6015-455D-BFE7-01201B629774" }, token);
        
<br>
<br>

 <h3>67. Запит на отримання повних реквізитів та контенту судових документів організації за критеріями</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetDecisionsByFilterClass.cs" target="_blank">[POST] /api/1.0/courtdecision/getdecisionsbyfilter</a></p>

GetDecisionsByFilterClass.GetDecisionsByFilter("00131305", 0, 1, 2, new List<string>() { "F545D851-6015-455D-BFE7-01201B629774" }, token);

<br>
<br>

<h3>68. Анкета</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetAnketaClass.cs" target="_blank">[POST] /api/1.0/organizations/GetAnketa</a></p>

GetAnketaClass.GetAnketa(ref token, "41462280");

<br>
<br>

<h3>69. API 2.0 Конструктор API</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/ApiConstructorClass.cs" target="_blank">[POST] /api/2.0/ApiConstructor</a></p>

ApiConstructorClass.ApiConstructor(ref token, "25412361",  new HashSet<int>{ 4, 9, 41, 37, 66, 32, 39, 70, 71 }); // 57

<br>
<br>

<h3>70. Скорочені основні фінансові показники діяльності підприємства</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgFinanceShortClass.cs" target="_blank">[POST] /api/1.0/organizations/GetOrgFinanceShort</a></p>

GetOrgFinanceShortClass.GetOrgFinanceShort(ref token, "41462280", new List<int> { 2020, 2019 });

<br>
<br>

<h3>71. Фінансово промислові групи</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetFinancialIndustrialGroupClass.cs" target="_blank">[POST] /api/1.0/organizations/GetFinancialIndustrialGroup</a></p>

GetFinancialIndustrialGroupClass.GetFinancialIndustrialGroup(ref token, "41462280");

<br>
<br>

<h3>72. API з історії зміни даних в ЄДР</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetActivityOrgHistoryClass.cs" target="_blank">[POST] /api/1.0/organizations/getactivityorghistory</a></p>

GetActivityOrgHistoryClass.GetActivityOrgHistory(ref token, "44623955");

<br>
<br>

<h3>73. Відомості про субєктів господарювання які стоять на обліку в ДФС</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/CabinetTaxRegistrationClass.cs" target="_blank">[POST] /api/1.0/podatkova/cabinettaxregistration</a></p>

CabinetTaxRegistrationClass.CabinetTaxRegistration(ref token, "41462280");

<br>
<br>

<h3>74. Стан ФОПа та відомості про ЄП</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/CabinetTaxEdpodEpClass.cs" target="_blank">[POST] /api/1.0/podatkova/cabinettaxedpodep</a></p>

CabinetTaxEdpodEpClass.CabinetTaxEdpodEp(token, "3334800417", true);

<br>
<br>

<h3>75. API 2.0 Zemli конструктор API</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/ApiConstructorClass.cs" target="_blank">[POST] /api/2.0/ApiConstructorZemli</a></p>

ApiConstructorClass.ApiConstructor(ref token, "25412361", new HashSet<int> { 4, 9, 41, 37, 66, 32, 39, 70, 71 }); // 57

<br>
<br>

<h3>76. Перевірка чи знаходиться аблеса компанії/ФОП в зоні АТО (доступно в конструкторі API №76)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/CheckIfOrganizationsInAtoClass.cs" target="_blank">[POST] /api/1.0/organizations/CheckIfOrganizationsInAto</a></p>

CheckIfOrganizationsInAtoClass.CheckIfOrganizationsInAto(ref token, "25412361");

<br>
<br>

<h3>77. Перевірка ФОП/не ФОП, наявність ліцензій адвокат/нотаріус, наявність обтяжень ДРОРМ (доступно в конструкторі API №77)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/CheckFopStatusClass.cs" target="_blank">[POST] /api/1.0/person/CheckFopStatus</a></p>

CheckFopStatusClass.CheckFopStatus(ref token, "2674001651", true);

<br>
<br>

<h3>78. Перевірка контрагента в списках санкції (доступно в конструкторі API №78)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgSanctionsClass.cs" target="_blank">[POST] /api/organizations/GetOrgSanctions</a></p>

GetOrgSanctionsClass.GetOrgSanctions(ref token, "00131305");

<br>
<br>

<h3>79. Реєстр платників ПДВ (доступно в конструкторі API №79)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgPdvClass.cs" target="_blank">[POST] /api/organizations/GetOrgPdv</a></p>

GetOrgPdvClass.GetOrgPdv(ref token, "00131305");

<br>
<br>

<h3>80. Анульована реєстрація платником ПДВ (доступно в конструкторі API №80)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrgAnulPdvClass.cs" target="_blank">[POST] /api/organizations/GetOrgAnulPdv</a></p>

GetOrgAnulPdvClass.GetOrgAnulPdv(ref token, "00131305");

<br>
<br>

<h3>81. Реєстр платників Єдиного податку (доступно в конструкторі API №81)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetYedynyyPodatokClass.cs" target="_blank">[POST] /api/organizations/GetYedynyyPodatok</a></p>

GetYedynyyPodatokClass.GetYedynyyPodatok(ref token, "00131305");

<br>
<br>

<h3>82. Реєстр ДФС “Дізнайся більше про свого бізнес-партнера” (доступно в конструкторі API №82)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetDfsBussinesPartnerDataClass.cs" target="_blank">[POST] /api/organizations/GetDfsBussinesPartnerData</a></p>

GetDfsBussinesPartnerDataClass.GetDfsBussinesPartnerData(ref token, "00131305");

<br>
<br>

<h3>83. Штатна чисельність працівників (доступно в конструкторі API №83)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetKilkistPracivnukiv.cs" target="_blank">[POST] /api/organizations/GetKilkistPracivnukiv</a></p>

GetKilkistPracivnukivClass.GetKilkistPracivnukiv(ref token, "00131305");

<br>
<br>

<h3>84. Реєстр ДФС “Стан розрахунків з бюджетом” (доступно в конструкторі API №84)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOrganizationDbDebtorsDfsClass.cs" target="_blank">[POST] /api/organizations/GetOrganizationDbDebtorsDfs</a></p>

GetOrganizationDbDebtorsDfsClass.GetOrganizationDbDebtorsDfs(ref token, "00131305");

<br>
<br>

<h3>85. Єдиний реєстр боржників (доступно в конструкторі API №85)</h3>
<p><a href="https://github.com/vkursi-pro/API/blob/master/vkursi-api-example/organizations/GetOpenEnforcementsClass.cs" target="_blank">[POST] /api/organizations/GetOpenEnforcements</a></p>

GetOpenEnforcementsClass.GetOpenEnforcements(ref token, "00131305");
        
<br>
<br>

<h3>Перелік статусів відповідей API</h3>
