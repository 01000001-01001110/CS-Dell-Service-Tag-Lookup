# Welcome 

In my organization we are primarily a Dell house. With a few other devices scattered between. <br>
Sure we can keep links to the sites, input data manually, and that's fine. However, this is the age of apps.<br>
With that I set out to learn more about C# and this was a project that involved a lot of what I have already done in PowerShell using Windows Forms. <br>
<br>
Screenshot:<br>
![image](https://user-images.githubusercontent.com/48245017/76416099-cde44e80-6370-11ea-9231-748bb49703bb.png)

I originally wanted to use the Dell RestAPI, and coded this solution, however our organization does not use the API. So I back burner'd the RestAPI code and found another way (albeit a bit jerry rigged, because ghetto is offesive) to look up the info we need. 

The program offers three links.<br>
<b>-Dell Warranty<br>
-Dell Drivers<br>
-Dell TechDirect<br></b>

Warranty and drivers were a trick without the API. For instance here's the link to find drivers for a computer: <br>
<b>https://www.dell.com/support/home/us/en/04/product-support/servicetag/LONGSETOFALPHANUMERICS/overview</b>

Interesting thing I found as I worked through this problem... You can replace the long set of alphanumerics <b>(LONGSETOFALPHANUMERICS)</b> with your service tag and the Dell site will automatically convert it and provide the correct link. No API needed.

So my hackey hack was: <br>
<b>Process.Start("https://www.dell.com/support/home/us/en/04/product-support/servicetag/" + dellServiceTag + "/overview");</b>
