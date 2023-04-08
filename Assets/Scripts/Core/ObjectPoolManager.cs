using UnityEngine;
using UnityEngine.Serialization;

public class ObjectPoolManager : MonoBehaviour
{ 
    [SerializeField] private GameObject objectToPool_;
    [Range(5,100)] [SerializeField] private int firstPoolSize_ = 5;
    
    void Start()
    {
        //poolSize分のオブジェクトを貯めておく
        for (int i = 0; i < firstPoolSize_; i++)
        {
            GameObject obj = addNewObject();
            obj.SetActive(false);
        }
    }

    public bool TryGetAbleUseGameObjectFirst(out GameObject activeObject)
    {
        int childCount = transform.childCount;
        for (int i = 0; i < childCount; i++)
        {
            GameObject obj = transform.GetChild(i).gameObject;
            //もし、オブジェクトがアクティブであれば、そのオブジェクトを返す
            if(obj.gameObject.activeSelf == false)
            {
                activeObject = obj;
                return true;
            }
        }
        activeObject = null;
        return false;
    }
    
    public GameObject addNewObject()
    {
        GameObject obj = Instantiate(objectToPool_);
        obj.transform.parent = transform;
        return obj;
    }
}