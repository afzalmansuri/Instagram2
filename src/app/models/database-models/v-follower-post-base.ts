import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vFollowerPostBase {

//#region followTo Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'followTo', keyColumn: false})
        followTo : number;
//#endregion followTo Prop


//#region followBy Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'followBy', keyColumn: true})
        followBy : number;
//#endregion followBy Prop


//#region postContent Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'postContent', keyColumn: false})
        postContent : string;
//#endregion postContent Prop


//#region postDateTime Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'postDateTime', keyColumn: false})
        postDateTime : any;
//#endregion postDateTime Prop

}