
using kimhyunwoo;
namespace Class4th
{
    class GameObjrct

    {
        #region 접근 지정자
        //클래스 내부의 포함되어있는 속성에
        //접근 범위를 제한하는 지정자입니다.
        #endregion
        int x; // default access specifier : 클래스에 접근 지정자를 설정하지 않으면 private로 설정됩니다.
        private int y;// private : 클래스 내부에서만 클래스의 속성을 접근할수있습니다
        protected int z;// prtected : 클래스 내부와 자기가 상속하고 있는 클래스에서만 접근을 허용할 수 있는 지정자 입니다.

        public void Move() // public : 클래스 내부와 클래스 외부에서 접근을 허용하는 지정자입니다.
        {
            Console.WriteLine("GameObject 이동");
        }
    }
    internal class Program
    {
        public void Function(int count)
        {
            if (count <= 0)
            {
                return;
            }
            Console.WriteLine("Recursive Call");

            Function(count-1);

            // 재귀함수의 경우 특정한 시점에서 함수를 반환해야
            // 하며 재귀적으로 호출한 함수는 스택 프레임에 의해
            // 마지막에 호출된 함수부터 차례대로 스택영역에서 사라집니다.
        }
        static void Main(string[] args)
        {
            // pull Request
    
            #region 클래스
            // 사용자 정의 데이터 유형으로 속성과 함수가
            // 포함되어 있으며 클래스를 통해
            // 객체를 생성하여 접근하고 사용할수 있는 집합체입니다

            //GameObjrct gameObject = new GameObjrct();

            //gameObject.Move();

            //클래스의 경우 클래스 내부에 있는 변수는 클래스의 메모리 영역에 포함되지만
            //정적 변수와 함수의 메모리는 클래스 영역에 포함되지 않습니다.

            #endregion

            #region 이름 공간
            //속성을 구분할 수 있도록 유효 범위를 설정하는 영역입니다.
            //kimhyunwoo.GameObject gameObject = new kimhyunwoo.GameObject();

            //gameObject.rotate();

            //이름공간은 같은 이름의 함수나 변수를 또 다른 공간에 선언하여 중복되지 않도록 선언할 수 있습니다.


            #endregion

            #region 생성자
            // 클래스의 인스턴스가 생성되는 시점에서 자동으로
            // 호출되는 특수한 맴버 함수입니다.
            //Transform tramsform = new Transform();

            //생성자의 경우 객체가 생성될때 단 한 번만
            //호출되며 생성자는 반환형이 존재하지 않습니다.

            #endregion

            #region 상속
            // 상위 클래스의 속성을 하위 클래스가
            // 사용할 수 있도록 설정해주는 기능입니다.

            //Component component = new Component();

            //RigidBody rigidBody = new RigidBody();
            //rigidBody.Information();

            // 클래스의 상속 관계에서 상위 클래스는 하위 클래스의 속성을 사용할 수 없으며,
            // 하위 클래스는 상위 클래스의 메모리를 포함한 상태로 메모리의 크기가 결정됩니다

            #endregion

            #region 재귀 함수
            // 어떤함수에서 자신을 다시 호출하여
            // 작업을 수행하는 함수입니다.

            //Program program = new Program();

            //program.Function(3);

            // 재귀함수는 함수를 계속 호출하기 때문에 스택
            // 영역에 메모리가 계속 쌓이게 되므로 스택
            // 오버플로우가 일어나게 됩니다.


            #endregion
        }
    }
}
