using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using tutdesk.Models;

namespace tutdesk.Services.Impl
{
    public static class UserService
    {
        private readonly static string _filePath = "user.json";

        public static void SaveUser(CurrentUser user)
        {
            var json = JsonSerializer.Serialize(user);
            File.WriteAllText(_filePath, json);
        }

        public static CurrentUser? LoadUser()
        {
            if (!File.Exists(_filePath))
                return null;

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<CurrentUser>(json);
        }
    }
}
