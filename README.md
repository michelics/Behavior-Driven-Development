# Behavior-Driven-Development
Examples of small projects using BDD to test

-- Open Visual Studio 2013 --
 
Step 1) Go to TOOLS –> Extension and Updates –> Search by SpecFlow: SpecFlow for Visual Studio 2013 - Install
 
Step 2) Go to File -> New -> Project -> Unit Test Project
 
Step 3) Install Packages: Go to TOOLS -> NuGet Package Manager -> Package Manager Console
 
* Install-Package Selenium.WebDriver
 
* Install-Package SpecFlow -Version 2.1.0

* Install-Package SpecFlow.MsTest -Version 2.1.0

* Install-Package SpecRun.SpecFlow -Version 1.6.0-rc007

* Install-Package SpecSync.MTM -Version 1.3.0-pre20170524
 
Step 5) MTM Integration
 
Step 5.1) Create test case on MTM and add the number as tag in the respective feature, example:
               
https://drive.google.com/open?id=0B-gOdMfqrRIAa0xMRk5qbzUyMi1kRmtudWV5RVlTeEtKRnFR

Step 5.2) Open prompt command and execute the steps below:
 
     Open the project folder and copy  specsync4mtm.cmd --tfsUrl http://tfs2.dell.com:8080/tfs/...
 
     Example: C:\Projects\BDD\CADET_APP\CADET_APP>specsync4mtm.cmd --tfsUrl http://tfs2.dell.c
                om:8080/tfs/xxxx/eDellPrograms

https://drive.google.com/file/d/0B-gOdMfqrRIAR3V5UWlLdlhyOGJCaGFETjhVQjNaYnpDZEhr/view?usp=sharing

