 namespace class2th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 상수
            // 프로그램이 싱행되는 동안 더 이상 값을
            // 변경할수 없는 메모리 공간입니다.

            const int data = 999;
            //상수는 메모리 공간을 생성하는 동사애 초기화해야 하며 ,
            // 한 번  저장된 값을 더 이상 변경할 수 없습니다.

            //ex) data = 100;

            // 상수의 경우 메모리 공간을 가지고 있지 않는 상수를 리터널 상수라고
            // 하며 메모리 공간을 가지고있는 상수를 심볼릭 상수라고 합니다.
            #endregion

            #region 조건문
            //어떤 동작이 주어질때 해당 조건에 따라
            //동작을 수행하도록 실행하는 명령문입니다.

            #endregion

            #region 관계연산자
            // 두개의 피연산자의 값을 비교하여 그 결과를
            // 0 또는 1이라는 값으로 나타내는 연산자입니다.

            // true : 참
            // false : 거짓
            //bool first = 10 < 5;
            //bool second = 10 > 5;
            //bool third = 10 <= 5;
            //bool fourth = 10 >= 5;
            //bool fifth = 10 == 5;
            //bool sixth = 10 != 5;


            //console.writeline("fisrt 변수의 값 :" + first);
            //console.writeline("second 변수의 값 :" + second);
            //console.writeline("third 변수의 값 :" + third);
            //console.writeline("fourth 변수의 값 :" + fourth);
            //console.writeline("fifth 변수의 값 :" + fifth);
            //console.writeline("sixth 변수의 값 :" + sixth);
            #endregion

            #region if문
            //어떤 특정한 조건을 비교하여 조건이 맞다면 실행되는
            //명령문입니다.

            //int monsterHP = 100;
            //if (monsterHP <= 0)
            //{ Console.WriteLine("Monster Die");

            //}


            // if문은 조건이 1일때 실행되며 0 이면 실행되지 않습니다.

            #endregion

            #region else if문
            //if문의 조건이 틀릴때 else if 문의 조건이 맞다면
            //실행되는 명령문입니다.

            //int level = 1;
            //if (level == 99)
            //{
            //    Console.WriteLine("승급가능");
            //        }
            //else if (level != 99)
            //{
            //    Console.WriteLine("승급 불가능");
            //        }



            #endregion

            #region else문
            //if 문과 else문의 조건이 다 틀리면
            //실행되는 명령문입니다.

            //int monny = 10000;
            //if (monny > 5000)
            //{ Console.WriteLine("무기구매"); 
            //}
            //else if (monny > 2500)
            //{ Console.WriteLine("소모품 구매"); 
            //}
            //else { Console.WriteLine("금액이 부족합니다");
            //}
            //if문의 연결된 모든 조건문의 조건이 맞을때
            //가장 위에있는 조건문만 실행됩니다.
            #endregion

            #region switch문
            //어떤 결과에 따라 그 결과부터
            //실행되는 명령문입니다

            //char grade = 'a';

            //switch (grade)
            //{
            //    case 'a': Console.WriteLine("a등급의 카드");
            //        break;
            //    case 'b':
            //        Console.WriteLine("b등급의 카드");
            //        break;
            //    case 'c':
            //        Console.WriteLine("c등급의 카드");
            //        break;
            //    default: Console.WriteLine("존재하지 않는 카드");
            //        break;
                
            }
        //swich문은  해당 조건이 완료되었을때 break문이 없으면
        //나머진 밑에있는 case 문까지 계속 실행시키다가 종료합니다.


        #endregion

            #region 비트
        //데이터를 나타내는 최소의 단위이며 0또는 1의 조합으로
        //논리 계산을 수행하는 단위입니다.


        //[1][0][1][0][0][0]
        // 메모리는 비트 단위로 데이터를 저장할수 있으며
        // 1개의  비트에는 0 또는 1의 값만 저장할수 있습니다.
        // <10진수를 2진수로 변환되는 과정>

        // 10진수를 1이 될떄 까지 계속 2로 나누어 준 다음 나눈위치의
        // 나머지값을 아래에서 위로 순서대로 정렬합니다.

        // <2진수를 10진수로 변환하는과정.>
        //1byte에  2 진수로 저장된 값을 2의 제곱으로 나타냅니다.

        //각각의 비트에 1이 있다면 1과 2의 제곱의 위치를 계산한
        //다음 각각의 비트를 모두 더하여 10진수로 나타낸다.
        #endregion
           
            #region 오버플로우
        //특정한 자료형아 표현할수있는 최댓값의 범위를
        //넘어서 연산을 수행하는 과정입니다.

        //ex) short gas = 32768;  X

        #endregion
           
            #region 언더플로우
        // 특정한 자료형이 표현할 수 있는 최솟값의
        // 범위를 넘어서 연산을 수행하는 과정입니다.

        //ex) short mineral = -32768;  X
        #endregion
            



            
            

    }
}