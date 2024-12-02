using System;
using System.Threading;
using TextCopy;

string title = "";
Console.Title = "Title to Branch Name Converter";

while (string.IsNullOrWhiteSpace(title))
{
    Console.WriteLine("Paste your Title:");
    title = Console.ReadLine();
}

string branchName = title
    .Replace(" ", "-")
    .Replace(",", "")
    .Replace(".", "")
    .ToLower();

branchName = branchName.Length > 50 ? branchName[.. 50] : branchName;
ClipboardService.SetText(branchName);

Console.WriteLine(branchName);

Thread.Sleep(5000);