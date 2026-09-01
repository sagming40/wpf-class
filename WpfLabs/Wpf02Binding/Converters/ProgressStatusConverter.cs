using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Wpf02Binding.Converters
{
    /*
        Converters
        Convert(변환), Converter(변환기)
        소스의 값을 타겟에서 사용하기 좋은 형태로 변환하는 클래스를 모아두는 영역

        ProgressStatusConverter
            : 숫자로 지정된 Progress를 업무 상태의 문자열로 변환한다.
            예시)
            progress = 0 -> "시작 전"
            progress = 1~99 -> "진행 중"
            progress = 100 -> "완료"

        IValueConverter
         : 하나의 Binding 값을 변환할 때 사용하는 인터페이스
        Convert     : Source -> Target 방향으로 값을 변환 
        ConvertBack : Target ->Source 방향으로 값을 변환 
    */
    internal class ProgressStatusConverter : IValueConverter
    {
        /*
            Convert
            Source 값이 Target으로 전달될때 WPF가 호출
            value에는 
        */
        public object Convert(
            object value, // Binding된 Progress값을 전달
            Type targetType, 
            object parameter, 
            CultureInfo culture)
        {
            // value가 int
            if (value is int progress)
            {
                if (progress == 0)
                    return "시작 전";
                if (progress < 100)
                    return "진행 중";
                return "완료";        
            }

            return Binding.DoNothing; // int가 아닌 값이 들어오면 변환 안 함
        }

        /*
            ConvertBack
            Target 값을 다시 Source 형태로 변환
        */
        public object ConvertBack(object value, 
        Type targetType, 
        object parameter, 
        CultureInfo culture)
        {
            return Binding.DoNothing; // Source 값을 변경하지 않는다.
        }
    }
}
