using UnityEngine;
using UnityEngine.Animations;

[RequireComponent(typeof(PositionConstraint))]
public class RelNToNPosConstraint : _RelNToN
{
    private void Awake()
    {
        this.transform.position = VectorExt.GetMeanOf(RelTo);

        SetConstraint();
    }

    private void SetConstraint()
    {
        var posConstraint = GetComponent<PositionConstraint>();
        posConstraint.constraintActive = true;

        ConstraintSource constraintSource;
        foreach (var rel in RelTo)
        {
            var source = new ConstraintSource()
            {
                sourceTransform = rel.transform
            };
            posConstraint.AddSource(source);
        }
    }

}
