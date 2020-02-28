import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vFollowerBase {

//#region followers Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'followers', keyColumn: false})
        followers : string;
//#endregion followers Prop


//#region followTo Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'followTo', keyColumn: true})
        followTo : number;
//#endregion followTo Prop

}