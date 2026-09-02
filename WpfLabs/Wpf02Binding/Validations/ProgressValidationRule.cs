using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Wpf02Binding.Validations
{
    /*
        Validations (검증, 유효성 검사)
         - 사용자가 입력한 값이 올바른지 검사하는 클래스를 모아두는 영역
        
        ProgressValidationRule
         - 사용자가 입력한 진행률 값이 숫자이고 0~100 사이인지 검사
         Target에서 입력한 값을 Source에 저장하기 전에 검사하는 과정

        ValidationRule
          WPF Binding에서 사용할 검증(유효성) 규칙을 만들 때 상속하는 클래스
        
        ValidationResult
         - 검증의 성공 또는 실패 결과를 반환
    */
    class ProgressValidationRule : ValidationRule
    {
        /*
            Validate
             - 사용자가 입력한 값을 검사할 때 WPF가 자동 호출
        */
        public override ValidationResult Validate(
            object value, // TextBox에 입력한 값이 전달
            CultureInfo cultureInfo)
        {
            // 1. 숫자로 변환할 수 없으면 잘못된 입력으로 판단
            /*
                value?.ToString()
                 - value를 문자열(string)로 반환
                 - ?.는 null 조건 연산자로 value가 null이면
                   ToString() 실행하지 않고 null 반환
                
                int.TryParse()
                 - String을 int로 Parsing할 수 있는지 try하는 method
                 - success : true, fail : false

                out
                 - method가 result를 전달할 때 using하는 grammar
                 - TryParse가 Parsing한 int value를 progress Variable에 save

                out int progress
                 - int progress : int Variable를 선언
                 - Parsing에 success하면 Parsing된 number가 progress에 save
            */
            if (!int.TryParse(value?.ToString(), out int progress))
            {
                return new ValidationResult(false, "숫자을 입력하세요.");
            }
            
            // return new ValidationResult(false, "숫자를 입력하세요.");

            // 2. 0~100 사이의 값만 허용
            if (progress < 0 || progress > 100)
            {
                return new ValidationResult(false, "0~100 사이로 입력하세요.");
            }

            // return new ValidationResult(false, "0~100 사이로 입력하세요.");
        }
    }
}
