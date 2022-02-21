:: Make Proxy  (cs)
wsdl.exe /out:HyggeService.cs http://localhost/HyggeWS/HyggeService.asmx?WSDL

:: Compile HyggeService.cs
csc.exe /target:library /out:HyggeService.dll HyggeService.cs 

:: Compile PoemClient.cs 
csc.exe /out:PoemClient.exe /reference:HyggeService.dll PoemClient.cs 