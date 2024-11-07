using UnityEngine;

public class Singletone<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;

    public static T Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = (T)FindObjectOfType(typeof(T));
                //  씬(Scene)에 존재하는 특정 클래스의 첫 번째 인스턴스를 찾아 반환
                // 특정 타입의 오브젝트를 찾을 때 사용하는 메서드
                if (_instance == null) // 씬에 없다면
                {
                    string tName = typeof(T).ToString(); 
                    // 제네릭 타입 T의 이름을 문자열로 얻는 코드
                    var singletoneObj = new GameObject(tName); 
                    // tName 문자열을 이름으로 가진 새로운 GameObject를 생성
                    _instance = singletoneObj.AddComponent<T>();
                    // singletoneObj 오브젝트에 제네릭 타입 T의 컴포넌트를 추가하고, 그 참조를 _instance에 할당
                }
            }

            return _instance;
        }
    }
    void Awake()
    {
        if(_instance != null )
            DontDestroyOnLoad( _instance );
    }
}
