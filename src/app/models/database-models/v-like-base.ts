import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class VLikeBase {

//#region likedById Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'likedById', keyColumn: true})
        likedById : number;
//#endregion likedById Prop


//#region instaUserName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'instaUserName', keyColumn: false})
        instaUserName : string;
//#endregion instaUserName Prop


//#region postContent Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'postContent', keyColumn: false})
        postContent : string;
//#endregion postContent Prop


//#region instaUserId Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'instaUserId', keyColumn: false})
        instaUserId : number;
//#endregion instaUserId Prop

}