using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using OpenQA.Selenium;
using Selenium_UI_Web;
using webNUnit.Pages;


namespace webNUnit.Test; 

public class Tests : Basefree
{ private Config pageConfig;
    [SetUp] 
    public void SetupPage ()
    {
        pageConfig = new Config (driver);

    }
    [Test]
    public void runnCofig()
    {
        pageConfig.demoLink("Demo");
        pageConfig.breedInput("f72528b5-a5d7-4a17-b709-aba2db722307");
        pageConfig.getBreedButton("/html/body/main/div/div[2]/button");
        pageConfig.getclickURL("/html/body/main/div/div[2]/div/a");

    }
    [Test]
    public void runnCofigError()
    {
        pageConfig.demoLink("Demo1");
        pageConfig.breedInput("HAHA");
        pageConfig.getBreedButton("/html/body/main/div/div[2]/button");
        pageConfig.getclickURL("/html/body/main/div/div[2]/div/a");

    }


}