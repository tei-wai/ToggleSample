using UnityEngine;
using UnityEngine.UI;

public class LayoutToggles : MonoBehaviour
{
    [SerializeField] GameObject itemPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < 3; i++)
        {
            var item = Instantiate(itemPrefab);
            item.transform.SetParent(gameObject.transform, false);

            Sprite newSprite = Resources.Load<Sprite>("Images/"+ i.ToString());
            
            item.GetComponentInChildren<Image>().sprite = newSprite;
        } 
    }
}
