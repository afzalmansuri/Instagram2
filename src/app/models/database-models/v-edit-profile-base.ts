import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vEditProfileBase {

//#region userImage Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'userImage', keyColumn: false})
        userImage : string;
//#endregion userImage Prop


//#region instaUserFullName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'instaUserFullName', keyColumn: false})
        instaUserFullName : string;
//#endregion instaUserFullName Prop


//#region instaUserName Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'instaUserName', keyColumn: false})
        instaUserName : string;
//#endregion instaUserName Prop


//#region userWebsite Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'userWebsite', keyColumn: false})
        userWebsite : string;
//#endregion userWebsite Prop


//#region userBio Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'userBio', keyColumn: false})
        userBio : string;
//#endregion userBio Prop


//#region userGender Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'userGender', keyColumn: false})
        userGender : string;
//#endregion userGender Prop


//#region instaUserMobileNumber Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'instaUserMobileNumber', keyColumn: false})
        instaUserMobileNumber : string;
//#endregion instaUserMobileNumber Prop


//#region instaUserEmail Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'instaUserEmail', keyColumn: false})
        instaUserEmail : string;
//#endregion instaUserEmail Prop


//#region instaUserCountry Prop
        @gridColumn({visible: true, columnIndex:9, allowSorting: true, headerKey: 'instaUserCountry', keyColumn: false})
        instaUserCountry : string;
//#endregion instaUserCountry Prop


//#region instaUserId Prop
        @gridColumn({visible: true, columnIndex:10, allowSorting: true, headerKey: 'instaUserId', keyColumn: true})
        instaUserId : number;
//#endregion instaUserId Prop

}