// ***********************************************************************
// Copyright (c) 2018 Charlie Poole
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// ***********************************************************************

#define TREE_BASED

using System;
using System.Windows.Forms;

namespace TestCentric.Gui
{
    using Model;
    using SettingsPages;

    /// <summary>
    /// Static class used to switch between the tree-based and tab-based
    /// versions of the actual SettingsDialog.
    /// </summary>
    public static class SettingsDialog
    {
#if TREE_BASED
        public static void Display( Form owner, ITestModel model )
        {
            TreeBasedSettingsDialog.Display(owner, model,
            new GuiSettingsPage("Gui.General"),
            new TreeSettingsPage("Gui.Tree Display"),
            new AssemblyReloadSettingsPage("Gui.Assembly Reload"),
            new TextOutputSettingsPage("Gui.Text Output"),
            new ProjectEditorSettingsPage("Gui.Project Editor"),
            new TestLoaderSettingsPage("Engine.Assembly Isolation"),
            new AdvancedLoaderSettingsPage("Engine.Advanced"));
        }
#else
        public static void Display( Form owner, ITestModel model )
        {
            TabbedSettingsDialog.Display( owner, model,
                new GuiSettingsPage("General"),
                new TreeSettingsPage("Tree"),
                new TextOutputSettingsPage("Text Output"),
                new ProjectEditorSettingsPage("Project Editor"),
                new TestLoaderSettingsPage("Test Load"),
                new AssemblyReloadSettingsPage("Reload"),
                new AdvancedLoaderSettingsPage("Advanced"));
        }
#endif
    }
}
