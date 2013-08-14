/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.DynamoDBv2.Model;

namespace Amazon.DynamoDBv2
{
    /// <summary>
    /// Interface for accessing AmazonDynamoDBv2.
    /// 
    /// Amazon DynamoDB <b>Overview</b> <para>This is the Amazon DynamoDB API Reference. This guide provides descriptions and samples of the Amazon
    /// DynamoDB API. </para>
    /// </summary>
	public partial interface IAmazonDynamoDB : IDisposable
    {
 
        /// <summary>
        /// <para>The <i>BatchGetItem</i> operation returns the attributes of one or more items from one or more tables. You identify requested items by
        /// primary key.</para> <para>A single operation can retrieve up to 1 MB of data, which can comprise as many as 100 items. <i>BatchGetItem</i>
        /// will return a partial result if the response size limit is exceeded, the table's provisioned throughput is exceeded, or an internal
        /// processing failure occurs. If a partial result is returned, the operation returns a value for <i>UnprocessedKeys</i> . You can use this
        /// value to retry the operation starting with the next item to get.</para> <para>For example, if you ask to retrieve 100 items, but each
        /// individual item is 50 KB in size, the system returns 20 items (1 MB) and an appropriate <i>UnprocessedKeys</i> value so you can get the next
        /// page of results. If desired, your application can include its own logic to assemble the pages of results into one dataset.</para> <para>If
        /// no items can be processed because of insufficient provisioned throughput on each of the tables involved in the request, <i>BatchGetItem</i>
        /// throws <i>ProvisionedThroughputExceededException</i> . </para> <para>By default, <i>BatchGetItem</i> performs eventually consistent reads on
        /// every table in the request. If you want strongly consistent reads instead, you can set <i>ConsistentRead</i> to <c>true</c> for any or all
        /// tables.</para> <para>In order to minimize response latency, <i>BatchGetItem</i> fetches items in parallel.</para> <para>When designing your
        /// application, keep in mind that Amazon DynamoDB does not return attributes in any particular order. To help parse the response by item,
        /// include the primary key values for the items in your request in the <i>AttributesToGet</i> parameter.</para> <para>If a requested item does
        /// not exist, it is not returned in the result. Requests for nonexistent items consume the minimum read capacity units according to the type of
        /// read. For more information, see Capacity Units Calculations in the Amazon DynamoDB Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="batchGetItemRequest">Container for the necessary parameters to execute the BatchGetItem service method on
        /// AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the BatchGetItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<BatchGetItemResponse> BatchGetItemAsync(BatchGetItemRequest batchGetItemRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>The <i>BatchWriteItem</i> operation puts or deletes multiple items in one or more tables. A single call to <i>BatchWriteItem</i> can
        /// write up to 1 MB of data, which can comprise as many as 25 put or delete requests. Individual items to be written can be as large as 64
        /// KB.</para> <para><b>NOTE:</b> BatchWriteItem cannot update items. To update items, use the UpdateItem API. </para> <para>The individual
        /// <i>PutItem</i> and <i>DeleteItem</i> operations specified in <i>BatchWriteItem</i> are atomic; however <i>BatchWriteItem</i> as a whole is
        /// not. If any requested operations fail because the table's provisioned throughput is exceeded or an internal processing failure occurs, the
        /// failed operations are returned in the <i>UnprocessedItems</i> response parameter. You can investigate and optionally resend the requests.
        /// Typically, you would call <i>BatchWriteItem</i> in a loop. Each iteration would check for unprocessed items and submit a new
        /// <i>BatchWriteItem</i> request with those unprocessed items until all items have been processed.</para> <para>To write one item, you can use
        /// the <i>PutItem</i> operation; to delete one item, you can use the <i>DeleteItem</i> operation.</para> <para>With <i>BatchWriteItem</i> , you
        /// can efficiently write or delete large amounts of data, such as from Amazon Elastic MapReduce (EMR), or copy data from another database into
        /// Amazon DynamoDB. In order to improve performance with these large-scale operations, <i>BatchWriteItem</i> does not behave in the same way as
        /// individual <i>PutItem</i> and <i>DeleteItem</i> calls would For example, you cannot specify conditions on individual put and delete
        /// requests, and <i>BatchWriteItem</i> does not return deleted items in the response.</para> <para>If you use a programming language that
        /// supports concurrency, such as Java, you can use threads to write items in parallel. Your application must include the necessary logic to
        /// manage the threads.</para> <para>With languages that don't support threading, such as PHP, <i>BatchWriteItem</i> will write or delete the
        /// specified items one at a time. In both situations, <i>BatchWriteItem</i> provides an alternative where the API performs the specified put
        /// and delete operations in parallel, giving you the power of the thread pool approach without having to introduce complexity into your
        /// application.</para> <para>Parallel processing reduces latency, but each specified put and delete request consumes the same number of write
        /// capacity units whether it is processed in parallel or not. Delete operations on nonexistent items consume one write capacity unit.</para>
        /// <para>If one or more of the following is true, Amazon DynamoDB rejects the entire batch write operation:</para>
        /// <ul>
        /// <li> <para>One or more tables specified in the <i>BatchWriteItem</i> request does not exist.</para> </li>
        /// <li> <para>Primary key attributes specified on an item in the request do not match those in the corresponding table's primary key
        /// schema.</para> </li>
        /// <li> <para>You try to perform multiple operations on the same item in the same <i>BatchWriteItem</i> request. For example, you cannot put
        /// and delete the same item in the same <i>BatchWriteItem</i> request. </para> </li>
        /// <li> <para>The total request size exceeds 1 MB.</para> </li>
        /// <li> <para>Any individual item in a batch exceeds 64 KB.</para> </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="batchWriteItemRequest">Container for the necessary parameters to execute the BatchWriteItem service method on
        /// AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the BatchWriteItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<BatchWriteItemResponse> BatchWriteItemAsync(BatchWriteItemRequest batchWriteItemRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>The <i>CreateTable</i> operation adds a new table to your account. In an AWS account, table names must be unique within each region.
        /// That is, you can have two tables with same name if you create the tables in different regions.</para> <para> <i>CreateTable</i> is an
        /// asynchronous operation. Upon receiving a <i>CreateTable</i> request, Amazon DynamoDB immediately returns a response with a
        /// <i>TableStatus</i> of <c>CREATING</c> . After the table is created, Amazon DynamoDB sets the <i>TableStatus</i> to <c>ACTIVE</c> . You can
        /// perform read and write operations only on an <c>ACTIVE</c> table. </para> <para>If you want to create multiple tables with local secondary
        /// indexes on them, you must create them sequentially. Only one table with local secondary indexes can be in the <c>CREATING</c> state at any
        /// given time.</para> <para>You can use the <i>DescribeTable</i> API to check the table status.</para>
        /// </summary>
        /// 
        /// <param name="createTableRequest">Container for the necessary parameters to execute the CreateTable service method on
        /// AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the CreateTable service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateTableResponse> CreateTableAsync(CreateTableRequest createTableRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes a single item in a table by primary key. You can perform a conditional delete operation that deletes the item if it exists, or
        /// if it has an expected attribute value.</para> <para>In addition to deleting an item, you can also return the item's attribute values in the
        /// same operation, using the <i>ReturnValues</i> parameter.</para> <para>Unless you specify conditions, the <i>DeleteItem</i> is an idempotent
        /// operation; running it multiple times on the same item or attribute does <i>not</i> result in an error response.</para> <para>Conditional
        /// deletes are useful for only deleting items if specific conditions are met. If those conditions are met, Amazon DynamoDB performs the delete.
        /// Otherwise, the item is not deleted. </para>
        /// </summary>
        /// 
        /// <param name="deleteItemRequest">Container for the necessary parameters to execute the DeleteItem service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the DeleteItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ConditionalCheckFailedException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteItemResponse> DeleteItemAsync(DeleteItemRequest deleteItemRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>The <i>DeleteTable</i> operation deletes a table and all of its items. After a <i>DeleteTable</i> request, the specified table is in
        /// the <c>DELETING</c> state until Amazon DynamoDB completes the deletion. If the table is in the <c>ACTIVE</c> state, you can delete it. If a
        /// table is in <c>CREATING</c> or <c>UPDATING</c> states, then Amazon DynamoDB returns a
        /// <i>ResourceInUseException</i> . If the specified table does not exist, Amazon DynamoDB returns a
        /// <i>ResourceNotFoundException</i> . If table is already in the <c>DELETING</c> state, no error is returned. </para> <para><b>NOTE:</b> Amazon
        /// DynamoDB might continue to accept data read and write operations, such as GetItem and PutItem, on a table in the DELETING state until the
        /// table deletion is complete. </para> <para>When you delete a table, any local secondary indexes on that table are also deleted.</para>
        /// <para>Use the <i>DescribeTable</i> API to check the status of the table. </para>
        /// </summary>
        /// 
        /// <param name="deleteTableRequest">Container for the necessary parameters to execute the DeleteTable service method on
        /// AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the DeleteTable service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteTableResponse> DeleteTableAsync(DeleteTableRequest deleteTableRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns information about the table, including the current status of the table, when it was created, the primary key schema, and any
        /// indexes on the table.</para>
        /// </summary>
        /// 
        /// <param name="describeTableRequest">Container for the necessary parameters to execute the DescribeTable service method on
        /// AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the DescribeTable service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeTableResponse> DescribeTableAsync(DescribeTableRequest describeTableRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>The <i>GetItem</i> operation returns a set of attributes for the item with the given primary key. If there is no matching item,
        /// <i>GetItem</i> does not return any data.</para> <para> <i>GetItem</i> provides an eventually consistent read by default. If your application
        /// requires a strongly consistent read, set <i>ConsistentRead</i> to <c>true</c> . Although a strongly consistent read might take more time
        /// than an eventually consistent read, it always returns the last updated value.</para>
        /// </summary>
        /// 
        /// <param name="getItemRequest">Container for the necessary parameters to execute the GetItem service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the GetItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetItemResponse> GetItemAsync(GetItemRequest getItemRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns an array of all the tables associated with the current account and endpoint. </para>
        /// </summary>
        /// 
        /// <param name="listTablesRequest">Container for the necessary parameters to execute the ListTables service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the ListTables service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListTablesResponse> ListTablesAsync(ListTablesRequest listTablesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Creates a new item, or replaces an old item with a new item. If an item already exists in the specified table with the same primary
        /// key, the new item completely replaces the existing item. You can perform a conditional put (insert a new item if one with the specified
        /// primary key doesn't exist), or replace an existing item if it has certain attribute values. </para> <para>In addition to putting an item,
        /// you can also return the item's attribute values in the same operation, using the <i>ReturnValues</i> parameter.</para> <para>When you add an
        /// item, the primary key attribute(s) are the only required attributes. Attribute values cannot be null. String and binary type attributes must
        /// have lengths greater than zero. Set type attributes cannot be empty. Requests with empty values will be rejected with a
        /// <i>ValidationException</i> .</para> <para>You can request that <i>PutItem</i> return either a copy of the old item (before the update) or a
        /// copy of the new item (after the update). For more information, see the <i>ReturnValues</i> description.</para> <para><b>NOTE:</b> To prevent
        /// a new item from replacing an existing item, use a conditional put operation with Exists set to false for the primary key attribute, or
        /// attributes. </para> <para>For more information about using this API, see Working with Items in the Amazon DynamoDB Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="putItemRequest">Container for the necessary parameters to execute the PutItem service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the PutItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ConditionalCheckFailedException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutItemResponse> PutItemAsync(PutItemRequest putItemRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>A <i>Query</i> operation directly accesses items from a table using the table primary key, or from an index using the index key. You
        /// must provide a specific hash key value. You can narrow the scope of the query by using comparison operators on the range key value, or on
        /// the index key. You can use the <i>ScanIndexForward</i> parameter to get results in forward or reverse order, by range key or by index key.
        /// </para> <para>Queries that do not return results consume the minimum read capacity units according to the type of read.</para> <para>If the
        /// total number of items meeting the query criteria exceeds the result set size limit of 1 MB, the query stops and results are returned to the
        /// user with a <i>LastEvaluatedKey</i> to continue the query in a subsequent operation. Unlike a <i>Scan</i> operation, a <i>Query</i>
        /// operation never returns an empty result set <i>and</i> a
        /// <i>LastEvaluatedKey</i> . The <i>LastEvaluatedKey</i> is only provided if the results exceed 1 MB, or if you have used
        /// <i>Limit</i> . </para> <para>To request a strongly consistent result, set <i>ConsistentRead</i> to true.</para>
        /// </summary>
        /// 
        /// <param name="queryRequest">Container for the necessary parameters to execute the Query service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the Query service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<QueryResponse> QueryAsync(QueryRequest queryRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>The <i>Scan</i> operation returns one or more items and item attributes by accessing every item in the table. To have Amazon DynamoDB
        /// return fewer items, you can provide a <i>ScanFilter</i> .</para> <para>If the total number of scanned items exceeds the maximum data set
        /// size limit of 1 MB, the scan stops and results are returned to the user with a <i>LastEvaluatedKey</i> to continue the scan in a subsequent
        /// operation. The results also include the number of items exceeding the limit. A scan can result in no table data meeting the filter criteria.
        /// </para> <para>The result set is eventually consistent. </para> <para>By default, <i>Scan</i> operations proceed sequentially; however, for
        /// faster performance on large tables, applications can request a parallel <i>Scan</i> by specifying the <i>Segment</i> and
        /// <i>TotalSegments</i> parameters. For more information, see Parallel Scan in the Amazon DynamoDB Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="scanRequest">Container for the necessary parameters to execute the Scan service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the Scan service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ScanResponse> ScanAsync(ScanRequest scanRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Edits an existing item's attributes, or inserts a new item if it does not already exist. You can put, delete, or add attribute
        /// values. You can also perform a conditional update (insert a new attribute name-value pair if it doesn't exist, or replace an existing
        /// name-value pair if it has certain expected attribute values).</para> <para>In addition to updating an item, you can also return the item's
        /// attribute values in the same operation, using the <i>ReturnValues</i> parameter.</para>
        /// </summary>
        /// 
        /// <param name="updateItemRequest">Container for the necessary parameters to execute the UpdateItem service method on AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the UpdateItem service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ItemCollectionSizeLimitExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ConditionalCheckFailedException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ProvisionedThroughputExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateItemResponse> UpdateItemAsync(UpdateItemRequest updateItemRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Updates the provisioned throughput for the given table. Setting the throughput for a table helps you manage performance and is part of
        /// the provisioned throughput feature of Amazon DynamoDB.</para> <para>The provisioned throughput values can be upgraded or downgraded based on
        /// the maximums and minimums listed in the Limits section in the Amazon DynamoDB Developer Guide.</para> <para>The table must be in the
        /// <c>ACTIVE</c> state for this operation to succeed. <i>UpdateTable</i> is an asynchronous operation; while executing the operation, the table
        /// is in the <c>UPDATING</c> state. While the table is in the <c>UPDATING</c> state, the table still has the provisioned throughput from before
        /// the call. The new provisioned throughput setting is in effect only when the table returns to the <c>ACTIVE</c> state after the
        /// <i>UpdateTable</i> operation. </para> <para>You cannot add, modify or delete local secondary indexes using <i>UpdateTable</i> . Local
        /// secondary indexes can only be defined at table creation time.</para>
        /// </summary>
        /// 
        /// <param name="updateTableRequest">Container for the necessary parameters to execute the UpdateTable service method on
        /// AmazonDynamoDBv2.</param>
        /// 
        /// <returns>The response from the UpdateTable service method, as returned by AmazonDynamoDBv2.</returns>
        /// 
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceInUseException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.ResourceNotFoundException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.LimitExceededException" />
        /// <exception cref="T:Amazon.DynamoDBv2.Model.InternalServerErrorException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UpdateTableResponse> UpdateTableAsync(UpdateTableRequest updateTableRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
