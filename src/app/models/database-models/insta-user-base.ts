import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class InstaUserBase {

//#region instaUserId Prop
        @prop()
        instaUserId : number;
//#endregion instaUserId Prop


//#region instaUserName Prop
        @required()
        @maxLength({value:50})
        instaUserName : string;
//#endregion instaUserName Prop


//#region instaUserFullName Prop
        @maxLength({value:50})
        instaUserFullName : string;
//#endregion instaUserFullName Prop


//#region instaUserEmail Prop
        @maxLength({value:50})
        instaUserEmail : string;
//#endregion instaUserEmail Prop


//#region instaUserMobileNumber Prop
        @maxLength({value:50})
        instaUserMobileNumber : string;
//#endregion instaUserMobileNumber Prop


//#region instaUserPassword Prop
        @required()
        @maxLength({value:50})
        instaUserPassword : string;
//#endregion instaUserPassword Prop


//#region instaUserCountry Prop
        @required()
        @maxLength({value:50})
        instaUserCountry : string;
//#endregion instaUserCountry Prop


//#region userPrivacyId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        userPrivacyId : number;
//#endregion userPrivacyId Prop



































}