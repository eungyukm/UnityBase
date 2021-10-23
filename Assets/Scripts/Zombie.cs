using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{
    public GameObject player;
    public Animator animator;

    private float speed = 5f;
    private float accuracy = 0.1f;

    public GameObject VFX;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        animator = GetComponent<Animator>();
        animator.SetBool("IsRun", true);
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null)
        {
            // 플레이어를 바라 본다.
            transform.LookAt(player.transform);

            // y축으로 이동하지 않는 벡터 생성
            Vector3 goVectoer = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
            if (Vector3.Distance(transform.position, goVectoer) >= accuracy)
            {
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<CharacterManager>().hp -= 0.1f;
        Instantiate(VFX, other.transform);
        Destroy(gameObject);
    }
}
