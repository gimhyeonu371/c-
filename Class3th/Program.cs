using System.Globalization;

namespace Class3th
{
    internal class Program
    {
        static void Function()
        {
            for(int i = 0; i <5; i++)
            {
                Console.WriteLine("Function");
            }
        }
        static int Add(int X, int Y)
        {
            return X + Y;
        }
       

        static void Main(string[] args)
        {
            #region 반복문
            // 프로그램 내에서 특정한 작업을
            // 반복적으로 수행하는 명령문입니다.

            #region 증감 연산자
            //피연산자를 하나씩 증가시키거나
            //감소시킬때 사용하는 연산자입니다.
            //int damage = 0;
            //int health = ++damage;
            //Console.WriteLine("health 변수의 값 :" + health);
            //health = damage++;
            //Console.WriteLine("health 변수의 값 :" + health);
            //health = --damage;
            //Console.WriteLine("damage의 변수의 값:" + damage);
            //health = damage--;
            //전위 증감 연산자는 변수의  값을 증감시킨 후에
            //연산을 수행하고 후의 증감연산자는 연산을 수행한
            //다음 변수의 값을 증감시킵니다.
            #endregion

            #region for 문
            //초기식을 연산하여 조건식의 결과에 따라
            //특정한 횟수만큼 반복하는 반복문입니다.

            //for (int i = 1; i<= 5; i++)
            //{
            //    Console.Write(i+"");
            //}

            #endregion

            #region 중첩 for문
            //for (int i = 1; i <= 9; i++)
            //{
            //    for(int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine(i + "x"+ j+" =" + i * j);
            //    }

            //    Console.WriteLine("");
            //}

            #endregion

            #region while문
            //특정 조건을 만족할떄 까지 계속해서 주어진
            //명령문을 실행하는 반복문입니다

            //int count = 5;
            //while(count > 0)
            //{
            //    Console.WriteLine("Execution");

            //    count--;
            //}

            //While문의 경우 위에서 아래로 실행되며 아래에
            //있는 명령문의 실행이 다 끝나면 다시 위에있는
            //명령문으로 돌아가서 반복하는 구조입니다


            #endregion

            #region do-while문
            //조건과 상관없이 한 번의 작업을 수행한
            //다음조건에 따라 명령문을 실행하는 반복문입니다.
            //int number = 0;
            //do
            //{
            //    Console.WriteLine("try Login");

            //}
            //while (number > 1);

            #endregion

            #region continue 문
            //해당 조건문만 실행하지 않고 반복문은 이어서 실행하는 제어문입니다

            //for(int i =1; i <= 5; i++)
            //{
            //    if(i == 3)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}

            // 반복문에서 continue 문을 만나게되면 다시 위에서부터 차례대로 동작합니다


            #endregion


            #endregion

            #region 배열
            // 같은 자료형의 변수들로 이루어진 유한 집합입니다.

            //int[] array = new int[5];

            //// 배열의 경우 첫 번째 원소는 0부터 시작합니다.

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = (i+1) * 10;

            //    Console.WriteLine("array[" + i + "]" + "의 값:" + array[i]);
            //}

            //배열은 연속적인 메모리 공간을 가지며 , 배열의
            //이름은 배열의 시작주소를 가르킵니다.



            #endregion

            #region 함수
            //하나의 특별한 목적의 작업을 수행하기
            //위해 독립적으로 설계된 코드의 집합입니다.

            //Function();

            //함수의 경우 자료형과 반환하는 값의 형태가 일치하지
            //않으면 원하는 값을 얻을수 없으며 같은 이름의 함수를
            //중복으로 선언할수 없습니다.

            #region 매개 변수
            //함수의 정의에서 전달받은 인수를 함수 내부로
            //전달하기 위해 사용되는 변수입니다.

            //Console.WriteLine("add함수의 결과:" +Add(10, 20));



            //매개변수는 함수 내부에서만 연산이 이루어지며,
            //함수가 종료되면 메모리에서 사라지는 특성을 가지고 있습니다.

            #endregion

            #region 인수
            // 함수가 호출될때 매개변수에 실제로 전달되는 값입니다

            int a = 10;
            int b = 20;
            int temp = 0;

            temp = b;
            b = a;
            a = temp;
            Console.WriteLine("a값:"+ a);
            Console.WriteLine("b값:" + b);



            //인수의 경우 함수에 있는 매개변수의 수에 따라 전달할수있는
            //인수가 결정되며 값을 전달하는 인수와 값을 전달받는 매개변수의
            //자료형이 서로 일치해야 합니다.

            #endregion

            #endregion
        }
    }
}