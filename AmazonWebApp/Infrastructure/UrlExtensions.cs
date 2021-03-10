/*
Preston Loveland
Assignment 8
Section 1 Group 11*/
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmazonWebApp.Infrastructure
{
    //helps get the path and the qury for the the request for the cart
    public static class UrlExtensions
    {
    public static string PathAndQuery(this HttpRequest request) =>
    request.QueryString.HasValue ? $"{request.Path}{request.QueryString}" : request.Path.ToString();

    }
}
