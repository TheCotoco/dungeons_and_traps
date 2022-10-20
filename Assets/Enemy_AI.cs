using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{
    private CharacterController _enemyAI;
    private GameObject _playerScript;
    public float _speed;
    private float _rotationajust;
    public float timeToMove = 0.5f;
    private bool isMoving = false, isMovingLeft = false, isMovingRight = false;
    private Vector3 origPos, targetPos;

    // Start is called before the first frame update
    void Start()
    {
        _enemyAI = GetComponent<CharacterController>();
        _playerScript = GameObject.Find("mago_player"); ;
        
        if (_enemyAI == null)
            Debug.LogError("Enemy Script is null");
        if (_playerScript == null)
            Debug.LogError("Player Script is null");
        
        Debug.Log("EnemyRot: x:" + _enemyAI.transform.position.x + "y:" + _enemyAI.transform.position.y + "z:" + _enemyAI.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {

        if (!isMoving)
            StartCoroutine(AiEnemy());
    }

    private IEnumerator AiEnemy()
    {
        isMoving = true;
        origPos = transform.position;
        if (origPos.x <= 70.99f && !isMovingLeft)
        {
            isMovingRight = true;
            float elapsedTime = 0;
            targetPos = origPos + new Vector3(0.1f, 0.0f, 0.0f);
            //Debug.Log(origPos);
            //Debug.Log(targetPos);
            while (elapsedTime < timeToMove)
            {
                transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
                elapsedTime += Time.deltaTime;
                yield return null;
            }
        }
        else
            isMovingRight = false;

        if (origPos.x >= 67.90f && !isMovingRight)
        {
            isMovingLeft = true;
            float elapsedTime = 0;
            targetPos = origPos + new Vector3(-0.1f, 0.0f, 0.0f);
            //Debug.Log(origPos);
            //Debug.Log(targetPos);
            while (elapsedTime < timeToMove)
            {
                transform.position = Vector3.Lerp(origPos, targetPos, (elapsedTime / timeToMove));
                elapsedTime += Time.deltaTime;
                yield return null;
            }
        }
        else
        {
            isMovingLeft = false;
        }

        isMoving = false;

    }
}
