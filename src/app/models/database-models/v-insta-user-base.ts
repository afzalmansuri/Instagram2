import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vInstaUserBase {

//#region instaUserId Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'instaUserId', keyColumn: true})
        instaUserId : number;
//#endregion instaUserId Prop


//#region instaUserName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'instaUserName', keyColumn: false})
        instaUserName : string;
//#endregion instaUserName Prop


//#region instaUserEmail Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'instaUserEmail', keyColumn: false})
        instaUserEmail : string;
//#endregion instaUserEmail Prop


//#region instaUserMobileNumber Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'instaUserMobileNumber', keyColumn: false})
        instaUserMobileNumber : string;
//#endregion instaUserMobileNumber Prop


//#region instaUserPassword Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'instaUserPassword', keyColumn: false})
        instaUserPassword : string;
//#endregion instaUserPassword Prop

}