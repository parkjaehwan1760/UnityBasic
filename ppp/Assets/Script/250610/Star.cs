using System;
using UnityEngine;

//star += "★"; // 별
//star += "　"; // 빈칸
//star += "\n"; // 줄바꿈


public class Star : MonoBehaviour
{
    string star;

    void Start()
    {
        Phase1();
        Phase2();
        Phase3();
        Phase4();
        Phase5();
    }

    public void Phase1()
    {
        star = string.Empty; // 페이즈 시작 시 문자열을 비웁니다.

        // 페이즈 1: 각 줄에 해당 줄 번호만큼 별을 찍는 패턴
        // 예시: 5줄을 출력합니다. 원하시면 numberOfLines 값을 변경하세요.
        int numberOfLines = 5;

        for (int i = 1; i <= numberOfLines; i++) // i는 현재 줄의 번호 (1부터 numberOfLines까지)
        {
            // C#의 string 생성자를 사용하여 i개의 별 문자열을 만듭니다.
            string lineOfStars = new string('★', i);

            // star 변수에 현재 줄의 별들과 줄바꿈 문자를 추가합니다.
            star += lineOfStars;
            star += "\n"; // 줄바꿈 추가

            // 참고: 원본 코드의 Console.Write("★") 및 Console.Write("\n") 부분은
            // Unity에서 Debug.Log로 최종 출력하기 위해 star 변수에 누적하는 방식으로 변경되었습니다.
            // 만약 콘솔 앱처럼 실시간 출력이 필요하다면 이 부분을 Console.Write로 변경해야 합니다.
            // 하지만 Unity 환경에서는 Debug.Log로 한 번에 출력하는 것이 일반적입니다.
        }

        // 모든 줄의 별 패턴이 완성되면 Debug.Log로 Unity 콘솔에 출력합니다.
        Debug.Log("--- Phase 1 출력 ---");
        Debug.Log(star);
    }

    public void Phase2()
    {
        star = string.Empty;

        int height = 5; // 이미지에서는 첫 줄에 5개의 별이 있습니다.

        // 위에서 아래로 내려가면서 별의 개수는 줄어들고, 공백은 늘어납니다.
        for (int i = height; i >= 1; i--) // i는 현재 줄의 별 개수 (height에서 1까지 감소)
        {
            // 1. 공백 추가: (height - i) 만큼 공백을 추가하여 오른쪽 정렬
            //    예: height=5, i=5 (첫 줄): 공백 0개
            //    예: height=5, i=4: 공백 1개
            //    예: height=5, i=1 (마지막 줄): 공백 4개
            star += new string(' ', height - i);

            // 2. 별 추가: i 만큼 별을 추가
            star += new string('★', i);

            star += "\n"; // 줄바꿈
        }

        Debug.Log("--- Phase 2 출력 ---");
        Debug.Log(star);
    }



public void Phase3()
    {
        star = string.Empty; // 페이즈 시작 시 문자열을 비웁니다.

        // 패턴의 최대 너비/높이를 설정합니다.
        int maxHeight = 5; // 이미지에서 가장 긴 줄이 5개 별입니다.

        // 1. 위쪽 절반 패턴 생성 (별 개수가 증가하는 부분)
        for (int i = 1; i <= maxHeight; i++) // i는 현재 줄의 별 개수 (1부터 maxHeight까지)
        {
            star += new string('★', i); // i개의 별을 추가 (왼쪽 정렬)
            star += "\n"; // 줄바꿈 추가
        }

        // 2. 아래쪽 절반 패턴 생성 (별 개수가 감소하는 부분)
        // 가장 긴 줄 (maxHeight) 바로 다음 줄부터 시작하여 별 개수가 1이 될 때까지 줄어듭니다.
        for (int i = maxHeight - 1; i >= 1; i--) // i는 현재 줄의 별 개수 (maxHeight-1부터 1까지 감소)
        {
            star += new string('★', i); // i개의 별을 추가 (왼쪽 정렬)
            star += "\n"; // 줄바꿈 추가
        }

        Debug.Log("--- Phase 3 출력 ---");
        Debug.Log(star);
    }

    public void Phase4()
    {
        int height = 5; // 높이 설정 (별의 최대 개수)
        star = string.Empty;

        for (int i = 1; i <= height; i++)
        {
            // 빈칸 (height - i)개
            for (int j = 0; j < height - i; j++)
            {
                star += "　"; // 전각 공백 사용
            }
            // 별 (i)개
            for (int k = 0; k < i; k++)
            {
                star += "★"; // 별 문자 사용
            }
            star += "\n"; // 줄바꿈
        }

        // 아랫부분 (점점 줄어드는 별, 가장 긴 줄 제외)
        for (int i = height - 1; i >= 1; i--)
        {
            // 빈칸 (height - i)개
            for (int j = 0; j < height - i; j++)
            {
                star += "　"; // 전각 공백 사용
            }
            // 별 (i)개
            for (int k = 0; k < i; k++)
            {
                star += "★"; // 별 문자 사용
            }
            star += "\n";
        }
        Debug.Log(star);
    }

    public void Phase5()
    {
        star = string.Empty;

        int height = 5; // 다이아몬드의 높이 설정 (윗부분과 아랫부분의 줄 수)
        // 페이즈 5
        // 1. 다이아몬드의 윗부분 (피라미드 형태)
        // 줄 수 i는 0부터 height-1까지 증가합니다.
        // 각 줄은 (height - 1 - i)개의 공백과 (2 * i + 1)개의 별로 구성됩니다.
        for (int i = 0; i < height; i++)
        {
            // 앞부분 공백 추가
            for (int j = 0; j < height - 1 - i; j++)
            {
                star += "　"; // 전각 공백
            }

            // 별 추가
            for (int k = 0; k < 2 * i + 1; k++)
            {
                star += "★"; // 별 문자
            }
            star += "\n"; // 줄바꿈
        }

        // 2. 다이아몬드의 아랫부분 (역피라미드 형태)
        // 줄 수 i는 height-2부터 0까지 감소합니다.
        // (가장 넓은 줄은 윗부분에서 이미 그렸으므로 height-1이 아닌 height-2부터 시작)
        // 각 줄은 (height - 1 - i)개의 공백과 (2 * i + 1)개의 별로 구성됩니다.
        for (int i = height - 2; i >= 0; i--)
        {
            // 앞부분 공백 추가
            for (int j = 0; j < height - 1 - i; j++)
            {
                star += "　"; // 전각 공백
            }

            // 별 추가
            for (int k = 0; k < 2 * i + 1; k++)
            {
                star += "★"; // 별 문자
            }
            star += "\n"; // 줄바꿈
        }


        Debug.Log(star);
    }

}
