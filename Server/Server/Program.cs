﻿using System;

class Program
{
    static Server server; // сервер

    static void Main(string[] args)
    {
        try
        {
            server = new Server();
            server.Start();
            Console.ReadLine();
        }
        catch (Exception ex)
        {
            server.Disconnect();
            Console.WriteLine(ex.Message);
        }
    }
}