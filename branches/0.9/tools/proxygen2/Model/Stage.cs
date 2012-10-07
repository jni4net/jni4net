namespace com.jni4net.proxygen.Model
{
    public enum Stage
    {
        S0000_New = 0,
        S0100_ToMatch, // rename, lock sides
        S0200_FindBase,
        S0300_FindRoots,
        S0400_FindLeaves,

        S0700_Foreign, // create view
        S0800_ForeignBase, // create usage, configure or reflect
        S0900_ForeignInterfaces,// create usage, configure or reflect
        S1000_ForeignMembers,// create views from home
        S1100_ForeignMembersInherit,
        S1200_ForeignMembersConfigure,
        S1300_ForeignMembersRename,
        S1400_ForeignMembersSubstituteTypes,
        S1500_ForeignMembersReflect,//match

        S9999_Done,
    }
}