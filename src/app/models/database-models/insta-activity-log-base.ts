import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class InstaActivityLogBase {

//#region activityLogId Prop
        @prop()
        activityLogId : number;
//#endregion activityLogId Prop


//#region activityContent Prop
        @required()
        activityContent : string;
//#endregion activityContent Prop


//#region postId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        postId : number;
//#endregion postId Prop


//#region activityDateTime Prop
        @required()
        activityDateTime : any;
//#endregion activityDateTime Prop



}