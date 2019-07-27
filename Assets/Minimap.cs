using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minimap : MonoBehaviour
{
    public ScrollRect minimap;
    public Image mob;
    public RectTransform mobTr;

    float mapXsize = 100;
    float mapZsize = 100;

    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        minimap.normalizedPosition = new Vector2(0.5f, 0.5f);
        //mobTr.sizeDelta = new Vector2(20, 20);
        mobTr.anchoredPosition = new Vector2(20, 20);
    }

    Vector2 Get2DMapPosition()
    {
        Vector3 tmp = player.transform.position;
        tmp.x += 50;
        tmp.z += 50;
        float xRatio = tmp.x / mapXsize;
        float zRatio = tmp.z / mapZsize;
        Vector2 mimapPos = Vector2.zero;
        mimapPos.Set(xRatio, zRatio);
        return mimapPos;
    }
    // Update is called once per frame
    void Update()
    {
        minimap.normalizedPosition = Get2DMapPosition();
    }
}
