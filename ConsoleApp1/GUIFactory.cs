using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public interface GUIFactory
    {
        public Button createButton();
        public CheckBox createCheckBox();
    }



    public class WinFactory : GUIFactory
    {
        public Button createButton() { return new WinButton(); }
        public CheckBox createCheckBox() { return new WinCheckBox(); }
    }



    public class MacFactory : GUIFactory
    {
        public Button createButton() { return new MacButton(); }
        public CheckBox createCheckBox() { return new MacCheckBox(); }
    }



    public class Aplication
    {

        GUIFactory factory;

        Button button;

        public Aplication(GUIFactory factory) { this.factory = factory; }
        public void createUI() {  }
        public void Paint() { }

    }


    public interface Button { }
    public class WinButton : Button { }
    public class MacButton : Button { }
    public interface CheckBox { }
    public class WinCheckBox : CheckBox { }
    public class MacCheckBox : CheckBox { }

}
