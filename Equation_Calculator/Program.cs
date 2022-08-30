using System;

namespace Equation_Calculator
{
    internal class Program
    {
        /*
                1. 방정식 입력하기
        
                2. 방정식 해석하기
        
                    2.1 모든 미지수 찾기
        
                        2.1.1 space를 기준으로 잘라 배열에 담은다
        
                    2.2 동류항끼리 합산하기
        
                        2.2.1 지수가 큰 미지수부터 계산한다
        
                            2.2.1.1 통상적인 키보드 자판은 지수의 입력이 어려워 x2, 3x2 와 같은 식으로 문자 뒤에 수를 입력하는 방식을 선택했는데
                                    이때 작은 수 부터 탐색을 할 경우 x를 검색했을때 x2와 x3같은 수도 같이 검색이 될 수 있으므로 큰 수 먼저 검색해
                                    배열애서 꺼내 계산한 후 문자열에 차례대로 담아둔다
        
                        2.2.2
        */
        private void GetEquation()
        {
            Console.WriteLine("");
            Console.Write("Writw Equation : ");
            string equation = Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetEquation();
        }
    }
}
