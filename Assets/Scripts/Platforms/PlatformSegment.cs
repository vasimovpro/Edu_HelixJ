using UnityEngine;

namespace Platforms
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlatformSegment : MonoBehaviour
    {
        public void Bounce(float force, Vector3 center, float radius)
        {
            if (TryGetComponent(out Rigidbody rigidbody))
            {
                rigidbody.isKinematic = false;
                rigidbody.useGravity = true;
                rigidbody.AddExplosionForce(force, center, radius);
            }
        }
    }
}
