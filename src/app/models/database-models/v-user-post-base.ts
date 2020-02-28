import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vUserPostBase {

//#region postContent Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'postContent', keyColumn: false})
        postContent : string;
//#endregion postContent Prop


//#region instaUserId Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'instaUserId', keyColumn: true})
        instaUserId : number;
//#endregion instaUserId Prop

}