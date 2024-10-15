using System;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace API.DTOs;

public class UserDto
{
    public required string Username {get; set;}
    public required string Token {get; set;}

}
