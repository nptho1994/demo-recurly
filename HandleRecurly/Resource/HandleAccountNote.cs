using Recurly.Resources;
using System;
using System.Collections.Generic;
using System.Text;

namespace HandleRecurly.Resource
{
    public class HandleAccountNote
    {
        internal string GetListAccountNote(string accountId)
        {
            var notes = HandleClient.client.ListAccountNotes(accountId);
            string listNote = string.Empty;
            foreach (AccountNote note in notes)
            {
                listNote += note.Message + "\t";
            }
            return listNote;
        }

        internal string FetchAccountNote(string accountId)
        {
            try
            {
                string accountNoteId = "ojzlfe77ckto";
                AccountNote note = HandleClient.client.GetAccountNote(accountId, accountNoteId);
                return $"Fetched account note: {note.Message}";
            }
            catch (Recurly.Errors.NotFound ex)
            {
                // If the resource was not found
                // we may want to alert the user or just return null
                return $"Resource Not Found: {ex.Error.Message}";
            }
            catch (Recurly.Errors.ApiError ex)
            {
                // Use ApiError to catch a generic error from the API
                return $"Unexpected Recurly Error: {ex.Error.Message}";
            }

        }
    }
}
