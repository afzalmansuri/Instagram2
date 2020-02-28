import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vActivityLogBase {

//#region activityLogId Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'activityLogId', keyColumn: true})
        activityLogId : number;
//#endregion activityLogId Prop


//#region activityContent Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'activityContent', keyColumn: false})
        activityContent : string;
//#endregion activityContent Prop


//#region instaUserId Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'instaUserId', keyColumn: false})
        instaUserId : number;
//#endregion instaUserId Prop


//#region postId Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'postId', keyColumn: false})
        postId : number;
//#endregion postId Prop

}