# project_cars_c#

# description:   //תאור הפרויקט
# A system for managing meetings of a car company. Through the system, you can book meetings through agents of the requested vehicles

# entities:   //ישויות בפרויקט
# cars, agents, meeting.

# routes-cars                             //מיפוי הכתובות של הרכבים
# GET https://cars.co.il/cars            //שליפת כל הרכבים
# GET https://cars.co.il/cars/123       //שליפת רכב על פי מזהה
# POST https://cars.co.il/cars         //הוספת רכב
# DELETE https://cars.co.il/cars/123  //מחיקת רכב על פי מזהה

# routes-agents                              //מיפוי הכתובות של הסוכנים
# GET https://cars.co.il/agents             //שליפת כל הסוכנים
# GET https://cars.co.il/agents/123        //שליפת סוכן על פי מזהה
# POST https://cars.co.il/agents          //הוספת סוכן
# PUT https://cars.co.il/agents/123      //עריכת סוכן על פי מזהה
# DELETE https://cars.co.il/agents/123  //מחיקת סוכן על פי מזהה

# routes-meeting                             //מיפוי הכתובות של הפגישות
# GET https://cars.co.il/meeting            //שליפת כל הפגישות
# GET https://cars.co.il/meeting/123       //שליפת פגישה על פי מזהה
# POST https://cars.co.il/meeting         //הוספת פגישה
# DELETE https://cars.co.il/meeting/123  //מחיקת פגישה על פי מזהה

# routes-status                               //ערכת הסטטוס של הפגישות והרכבים
# PUT https://cars.co.il/cars/123/status     //עריכת סטטוס של רכב על פי מזהה
# PUT https://cars.co.il/meeting/123/status //עריכת הסטטוס של פגישה על פי מזהה
