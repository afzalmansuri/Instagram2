import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vCountryLookupBase {

//#region instaUserCountry Prop
        @gridColumn({visible: true, columnIndex:0, allowSorting: true, headerKey: 'instaUserCountry', keyColumn: false})
        instaUserCountry : string;
//#endregion instaUserCountry Prop

}