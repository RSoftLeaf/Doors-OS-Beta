using System;
using System.Runtime.InteropServices;
public class MyMethods
{
    #region REGIONS

    #region VARIABLES   

    public InputLanguage defLang;
    List<InputLanguage> inputLanguages = new List<InputLanguage>();

    #endregion

    #region LANGUAGES

    /*
    
    "00000419" Русский
    "00000422" Украинский
    "00000409" Английский (США)
    "00000407" Немецкий(стандартный)
    
   */
    #endregion

    #region DllImport

    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    public static extern bool PostMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

    [DllImport("user32.dll")]
    static extern int LoadKeyboardLayout(string pwszKLID, uint Flags);

    #endregion

    #region NOTCODE

    /*
        int ret = LoadKeyboardLayout(lang, 1);
        PostMessage(GetForegroundWindow(), 0x50, 1, ret);
        InputLanguageCollection ilc = InputLanguage.InstalledInputLanguages;
        defLang = InputLanguage.DefaultInputLanguage;
        foreach (InputLanguage il in ilc)
            if (il.Culture.EnglishName.Contains("Rus"))
                InputLanguage.CurrentInputLanguage = il;
        
        string lang = "00000422";
        string iso6391TwoLetterCode = InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName;
        int ret = LoadKeyboardLayout(lang, 1);
        PostMessage(GetForegroundWindow(), 0x50, 1, ret);
        /*
        InputLanguageCollection ilc = InputLanguage.InstalledInputLanguages;
        defLang = InputLanguage.DefaultInputLanguage;
        foreach (InputLanguage il in ilc)
            if (il.Culture.EnglishName.Contains("Rus"))
                InputLanguage.CurrentInputLanguage = il;
        MessageBox.Show(ret.ToString());
    

        InputLanguage inputLanguage = InputLanguage.CurrentInputLanguage;
        foreach (InputLanguage il in InputLanguage.InstalledInputLanguages)
        {
            MessageBox.Show(il.Culture.EnglishName + " ");
        }
         */

    #endregion

    #endregion
    public MyMethods()
    {
        foreach (InputLanguage il in InputLanguage.InstalledInputLanguages)
        {
            inputLanguages.Add(il);
        }
    }
    
    public void SetOpacity(Form form, System.Drawing.Point location)
    {
        form.Show();
        form.Location = location;
        form.Size = new System.Drawing.Size(700, 500);
        form.Opacity = 0;
        for (int i = 0; i < 50; i++)
        {
            //await Task.Delay(1);
            form.Size = new System.Drawing.Size(form.Size.Width, form.Size.Height + 2);
            form.Location = new System.Drawing.Point(form.Location.X, form.Location.Y - 2);
            form.Opacity += 0.02;
        }
    }
    public double GetWSHFolderSize(string Fldr)
    {
        //Reference "Windows Script Host Object Model" on the COM tab.
        IWshRuntimeLibrary.FileSystemObject FSO = new IWshRuntimeLibrary.FileSystemObject();
        double FldrSize = (double)FSO.GetFolder(Fldr).Size;
        Marshal.FinalReleaseComObject(FSO);
        return FldrSize;
    }
    public void EMPTY()
    {

    }
    public void ChangeLanguage()
    {
        InputLanguage currLang = InputLanguage.CurrentInputLanguage;
        for (int i = 0; i < inputLanguages.Count; i++)
        {
            if (currLang.LayoutName == inputLanguages[i].LayoutName)
            {
                if (i == inputLanguages.Count - 1)
                {
                    InputLanguage.CurrentInputLanguage = inputLanguages[0];
                }
                else
                {
                    InputLanguage.CurrentInputLanguage = inputLanguages[i + 1];
                }
            }
        }
        


    }
    public void Test1()
    {
        
    }

}