using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;
using System;




using (SqlConnection connection = new SqlConnection())  
    {  
        connection.Open();
        var Server=myServerAddress;
        var Database=myDataBase;
        var Uid=myUsername;
        var Pwd=myPassword;
        
    } 




