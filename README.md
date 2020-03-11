# Welcome to the Dell Service Tag Lookup Tool 

This application looks up the Service Tag on the computer from Bios, and converts the service tag to express service code, displaying both. 

Screenshot:
![image](https://user-images.githubusercontent.com/48245017/76416099-cde44e80-6370-11ea-9231-748bb49703bb.png)

I originally wanted to use the Dell RestAPI, however our organization does not use the API. So I found another way to look up the info we need. 

The program offers three links. 
-Dell Warranty
-Dell Drivers
-Dell TechDirect

Warranty and drivers were a trick without the API. For instance here's the link to find drivers for a computer: 
https://www.dell.com/support/home/us/en/04/product-support/servicetag/LONGSETOFALPHANUMERICS/overview

Interesting thing I found as I worked through this problem... You can replace the long set of alphanumerics (LONGSETOFALPHANUMERICS) with your service tag and the Dell site will automatically convert it and provide the correct link. No API needed.

So my hackey hack was: 
Process.Start("https://www.dell.com/support/home/us/en/04/product-support/servicetag/" + dellServiceTag + "/overview");
