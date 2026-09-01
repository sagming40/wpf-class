using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

/*
    WPF 프로젝트 구조
    WpfLabs (솔루션)
     |- Wpf01Basic (프로젝트)
        |- Dependencies
        |- App.xaml
        |- MainWindow.xaml
        |- ... 
     |- ...

     Solution (솔루션)
      - Visual Studio에서 하나 이상의 Project를 관리하는 단위
     
     Project (프로젝트)
      - 실제 프로그램을 구성하는 Source Code, Resource, Configuration 등을 포함하는 단위

     Dependencies (의존성)
      - 프로젝트에서 참조하는 외부 라이브러리, NuGet 패키지 등을 관리하는 단위
     
     Framework (프레임워크)
      - 프로그램 개발에 필요한 기본 구조와 기능을 제공하는 개발 환경

     MicroSoft.NetCore.App (마이크로소프트 닷넷 코어 앱)
      - .NET Application의 기본 실행 환경을 제공
   
     .NET 이란?
        .NET
            - Microsoft에서 제공하는 Software Development Platform
            - C# 프로그램을 개발하고 실행하지 위한 환경과 기능을 제공
        C#
            - 프로그램의 동작을 작성하는 Programming Language
        WPF
            - .NET 기반의 Windows Desktop UI Framework
        Visual Studio
            - 코드를 작성하고 Build, Debug하는 IDE
        * Visual Studio > C# > .NET > WPF > Windows Desktop Application
        
*/

namespace Wpf01Basic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}