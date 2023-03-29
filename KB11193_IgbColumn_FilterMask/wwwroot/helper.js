/**
 * 指定した CSS セレクタで識別される Grid コンポーネント内の、指定したフィールドにバインドされている列について、
 * フィルタのマスク定義に使用される、デフォルトの日時フォーマットを設定する JavaScript 関数です。
 *
 * @param {string} gridSelector 対象の Grid コンポーネントを識別する CSS セレクタ文字列
 * @param {string} fieldName 日時フォーマットを指定する対象の列の、バインド項目名
 * @param {string} format 日時フォーマット (例: "yyyy/MM/dd HH:mm:ss")
 */
export const setDefaultDateTimeFormat = async (gridSelector, fieldName, format) => {

    const grid = document.querySelector(gridSelector);
    const column = grid?.columns.filter(c => c.field === fieldName)[0];
    if (column === null || typeof (column) === "undefined") throw new Error(`Column ${fieldName} in the grid ${gridSelector} wss not found`);

    // https://www.infragistics.com/products/ignite-ui-angular/docs/typescript/latest/interfaces/ColumnType.html#defaultDateTimeFormat

    column.defaultDateTimeFormat = format;
}