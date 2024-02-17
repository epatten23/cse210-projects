using System;
using System.Diagnostics.Metrics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

ScriptureReference scriptRef = new ScriptureReference(
  "Alma",
  37,
  "7",
  "And the Lord God doth work by means to bring about his great and eternal purposes; and by very small means the Lord doth confound the wise and bringeth about the salvation of many souls."
);

Console.WriteLine("\n[ VIEW SCRIPTUTRE ]\n");
scriptRef.ViewScriptue();

Console.WriteLine("\n[ VIEW SCRIPTUTRE IN PARTS ]\n");  
scriptRef.ViewScriptueParts();

Console.WriteLine("\n[ VIEW SCRIPTUTRE IN HIDDEN PARTS ]\n");
scriptRef.HideWords(11);
scriptRef.ViewScriptueParts();