using System;
using UnityEngine;

namespace Code.Player
{
    public class PlayerMove : MonoBehaviour
    {
        [SerializeField] private float speed;
        private Rigidbody2D playerRig;
        public float horizontalMove;
        private float jumpForce;
        public Vector2 direction;

        private void Start()
        {
            playerRig = GetComponent<Rigidbody2D>();
        }

        private void Move()
        {
            horizontalMove = Input.GetAxisRaw("Horizontal");
        }

        private void Update()
        {
            Move();
        }

        private void FixedUpdate()
        {
            direction = new Vector2((horizontalMove * speed), playerRig.velocity.y);
            playerRig.velocity = direction;
        }
    }
}
