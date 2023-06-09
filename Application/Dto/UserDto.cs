﻿namespace ProjectNetworkMediaApi.Dto
{
    public class UserDto
    {
        public int? Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int RoleId { get; set; }
        public IEnumerable<string>? ImagesPath { get; set; }
        public int NumberOfFriends { get; set; }
    }
}
