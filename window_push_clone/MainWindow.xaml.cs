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

namespace window_push_clone
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 사용자의 모니터 해상도 중 실제 사용 가능한 작업 영역(WorkArea) 계산
            var workingArea = SystemParameters.WorkArea;

            // 오른쪽 하단 구석 위치 좌표 계산 (모니터 끝에서 20픽셀씩 여백 배치)
            double leftPosition = workingArea.Right - this.Width - 20;
            double topPosition = workingArea.Bottom - this.Height - 20;

            // 계산된 좌표로 창 위치 이동
            this.Left = leftPosition;
            this.Top = topPosition;
        }

        // ✕ 버튼 클릭 시 창 닫기
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}