using Content.Shared.Body.Systems;
using Robust.Shared.Containers;
using Robust.Shared.GameStates;

namespace Content.Shared.Body.Organ;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(SharedBodySystem))]
public sealed partial class OrganComponent : Component
{
    /// <summary>
    /// Relevant body this organ is attached to.
    /// </summary>
    [DataField, AutoNetworkedField]
    public EntityUid? Body;

    [DataField("parent")]
    public OrganSlot? ParentSlot;

    [DataField("organType")]
    public OrganType OrganType = OrganType.Other;

    [DataField("internal")]
    public bool Internal = true;

    [DataField("species", required: true)]
    public string Species = "";
}
