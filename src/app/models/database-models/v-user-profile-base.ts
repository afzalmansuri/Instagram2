import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vUserProfileBase {

//#region instaUserId Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'instaUserId', keyColumn: true})
        instaUserId : number;
//#endregion instaUserId Prop


//#region instaUserName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'instaUserName', keyColumn: false})
        instaUserName : string;
//#endregion instaUserName Prop


//#region instaUserFullName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'instaUserFullName', keyColumn: false})
        instaUserFullName : string;
//#endregion instaUserFullName Prop


//#region userBio Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'userBio', keyColumn: false})
        userBio : string;
//#endregion userBio Prop


//#region userWebsite Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'userWebsite', keyColumn: false})
        userWebsite : string;
//#endregion userWebsite Prop


//#region userImage Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'userImage', keyColumn: false})
        userImage : string;
//#endregion userImage Prop

}