using UnityEngine;

namespace Platforms
{
    public class Platform: MonoBehaviour
    {
        [SerializeField] private float _bounceForce;
        [SerializeField] private float _bounceRadius;

        public void Break()
        {
            PlatformSegment[] platformSegments = GetComponentsInChildren<PlatformSegment>();

            foreach (var platformSegment in platformSegments)
            {
                platformSegment.Bounce(_bounceForce, transform.position, _bounceRadius);
            }
        }
    }
}