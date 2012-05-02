using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace TestProject1
{
    /// <summary>
    /// Сводное описание для LogIn
    /// </summary>
    [CodedUITest]
    public class GUITest
    {
        public GUITest()
        {
        }

        [TestMethod]
        public void GUI_LogIn()
        {
            this.UIMap.LogInParams.UITxtNameEditText = "Test1";
            this.UIMap.LogInParams.UITxtPassEditSendKeys = "K2gHpANDeOOtYhGGA0aZ04zjQIbIYSLh";
            this.UIMap.LogIn();
        }
        [TestMethod]
        public void GUI_AddAuthor()
        {
            this.UIMap.AddAuthorParams.UITxtAddAuthorEditText = "tstAuthor";
            this.UIMap.AddAuthor();
        }
        [TestMethod]
        public void GUI_AddBook()
        {
            this.UIMap.AddBook();
        }
        [TestMethod]
        public void GUI_AddUser()
        {
            this.UIMap.AddUser();
        }
        #region Дополнительные атрибуты тестирования

        // При написании тестов можно использовать следующие дополнительные атрибуты:

        ////TestInitialize используется для выполнения кода перед запуском каждого теста 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // Чтобы создать код для этого теста, выберите в контекстном меню команду "Сформировать код для кодированного теста ИП", а затем выберите один из пунктов меню.
        //    // Дополнительные сведения по сформированному коду см. по ссылке http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////TestCleanup используется для выполнения кода после завершения каждого теста
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // Чтобы создать код для этого теста, выберите в контекстном меню команду "Сформировать код для кодированного теста ИП", а затем выберите один из пунктов меню.
        //    // Дополнительные сведения по сформированному коду см. по ссылке http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
