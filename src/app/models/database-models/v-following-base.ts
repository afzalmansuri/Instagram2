import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vFollowingBase {

//#region following Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'following', keyColumn: false})
        following : string;
//#endregion following Prop


//#region followBy Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'followBy', keyColumn: true})
        followBy : number;
//#endregion followBy Prop

}