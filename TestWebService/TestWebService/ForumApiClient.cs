using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace TestWebService
{
    class ForumApiClient
    {
        public static UserData GetUser(string id)
        {
            var url = "http://localhost:8080/forum/users/"+id;

            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

            UserData userData;

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(UserData));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                userData = (UserData)serializer.ReadObject(ms);
            }

            return userData;
        }
        public static UsersData GetUsers()
        {
            var url = "http://localhost:8080/forum/users/";

            var syncClient = new WebClient();
            var content = syncClient.DownloadString(url);

            UsersData usersData;

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(UsersData));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(content)))
            {
                usersData = (UsersData)serializer.ReadObject(ms);
            }

            return usersData;
        }
    }
}
