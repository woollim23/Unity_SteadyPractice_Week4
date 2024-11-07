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
                //  ��(Scene)�� �����ϴ� Ư�� Ŭ������ ù ��° �ν��Ͻ��� ã�� ��ȯ
                // Ư�� Ÿ���� ������Ʈ�� ã�� �� ����ϴ� �޼���
                if (_instance == null) // ���� ���ٸ�
                {
                    string tName = typeof(T).ToString(); 
                    // ���׸� Ÿ�� T�� �̸��� ���ڿ��� ��� �ڵ�
                    var singletoneObj = new GameObject(tName); 
                    // tName ���ڿ��� �̸����� ���� ���ο� GameObject�� ����
                    _instance = singletoneObj.AddComponent<T>();
                    // singletoneObj ������Ʈ�� ���׸� Ÿ�� T�� ������Ʈ�� �߰��ϰ�, �� ������ _instance�� �Ҵ�
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
