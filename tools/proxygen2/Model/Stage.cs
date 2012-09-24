namespace com.jni4net.proxygen.Model
{
    public enum Stage
    {
        S0100_New = 0,
        S0200_ToMatch, // rename, lock sides
        S0300_FindBase,
        S0400_FindInterfaces,
        S0500_FindEnclosing,
        S0600_FindMembers,
        S0700_FindMemberTypes,

        S0800_Foreign, // create view
        S0800_ForeignBase, // create usage, configure or reflect
        S0900_ForeignInterfaces,// create usage, configure or reflect
        S1000_ForeignMembers,// create views from home
        S1000_ForeignMembersInherit,
        S1000_ForeignMembersConfigure,
        S1000_ForeignMembersRename,
        S1000_ForeignMembersSubstituteTypes,
        S1000_ForeignMembersReflect,//match

        S9999_Done,
    }
}