using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes; 
using System.Runtime.Serialization; 
namespace testdotnetcomp.Contracts.DTO {
   public class UserDto { 
     public string Id { get; set; }
        public int UserId { get; set; } 
        public string UserName { get; set; } 
        public int UserAge { get; set; } 
        public string UserPresent { get; set; } 
} 
}
