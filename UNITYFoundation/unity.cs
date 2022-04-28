public class unity : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");//Debug.Log(); = 출력

        //1.변수
        int level = 5;//int = 정수형 변수 level = 이름
        float strength = 15.5f;//float = 숫자형 변수 0.1 = 소수점은 뒤에는 f
        string playerName = "나검사";//string = 문자열 변수 문자열을 정자하는변수
        bool isFullLevel = false;//bool = 논리형 변수 참(true)/거짓(false) 판별하는

        //2.그룹형 변수
        string[] monsters = {"슬라임","사막뱀","악마"};//[]배열 = 0,1,2,3순서 {}<-배열에 들려갈값
        Debug.Log("몬스터 출현")//출력
        Debug.Log(monsters[0])//출력 배열
        Debug.Log(monsters[1])//출력 배열
        Debug.Log(monsters[2])//출력 배열
        
        int[] monsterLevel = new int[3];//new int[?]<-안에 숫만큼 배열생성
        monsterLevel[0] = 1;//배열안에 값추가
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;
        Debug.Log("몬스터 출현 레벨")//출력
        Debug.Log(monsterLevel[0])//출력 배열
        Debug.Log(monsterLevel[1])//출력 배열
        Debug.Log(monsterLevel[2])//출력 배열
        
        List<string> item = new List<string>();//기능이 추가된 가변형 그룹형변수 <><- 안에 타입변수[예시/string,int,float]
        item.Add("생명물약30");
        item.Add("마나물약30");
        
        item.Removeat(0);//List는 배열과 달리 안에있는 데이터 삭제가능
    
        Debug.Log("가진 아이템")//출력
        Debug.Log(item[0])//출력 리스트
        Debug.Log(item[1])//출력 리스트
        
        //3.연산자
        
        //3_1 수학
        int exp = 1500;
        exp = 1500 + 10;//더하기
        level = exp / 300;//나누기
        strength = level * 3.1f;//곱하기
        
        int expEXP = 300 - (exp % 300);//% = 모듈 나머지
        //3_2 문자열
        string title = "전설의";
        
        Debug.Log(title + "" + playerName)//문자열 더하기 출력
        
        //3_3 비교연산자
        int fullLevel = 99;
        isFullLevel = level == fullLevel;//==<- 서로 참일경우 참
        
        bool isEndTutorial = level > 10;//[>(최고)]/[<(미만)]/[>=(이상)]/[<=(이하)]
        
        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 && mana<= 20; //&&(AND)연산자 두 값이 모두 true 일 때만 true로 출력
        bool isBadCondition = health <= 50 || mana<= 20; // ||(OR) 두 값 중에서 하나만 true이면 true로 출력
        
        //4.키워드
        //해당 int float string bool new  List
        
        //5.조건문
        //if(조건){출력값이 true이출력 }
        //else{}if가 false일때 값을 출력
        //switch(변수){case 값} = switch 변수내에 값이 특정{case값}에끝낼때는 break; 
        //switch{변수}값에 없는 값을 출력힐떼defauit 사용
        
        //6.반복문
        //while (조건)true일때까지 {반복}
        //for (예시 int i = 0; i<=10; i++;){출력값}
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}