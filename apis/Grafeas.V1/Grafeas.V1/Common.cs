// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: grafeas/v1/common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grafeas.V1 {

  /// <summary>Holder for reflection information generated from grafeas/v1/common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for grafeas/v1/common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdncmFmZWFzL3YxL2NvbW1vbi5wcm90bxIKZ3JhZmVhcy52MSIoCgpSZWxh",
            "dGVkVXJsEgsKA3VybBgBIAEoCRINCgVsYWJlbBgCIAEoCSI1CglTaWduYXR1",
            "cmUSEQoJc2lnbmF0dXJlGAEgASgMEhUKDXB1YmxpY19rZXlfaWQYAiABKAkq",
            "mAEKCE5vdGVLaW5kEhkKFU5PVEVfS0lORF9VTlNQRUNJRklFRBAAEhEKDVZV",
            "TE5FUkFCSUxJVFkQARIJCgVCVUlMRBACEgkKBUlNQUdFEAMSCwoHUEFDS0FH",
            "RRAEEg4KCkRFUExPWU1FTlQQBRINCglESVNDT1ZFUlkQBhIPCgtBVFRFU1RB",
            "VElPThAHEgsKB1VQR1JBREUQCEJRCg1pby5ncmFmZWFzLnYxUAFaOGdvb2ds",
            "ZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvZ3JhZmVhcy92MTtn",
            "cmFmZWFzogIDR1JBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Grafeas.V1.NoteKind), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.RelatedUrl), global::Grafeas.V1.RelatedUrl.Parser, new[]{ "Url", "Label" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Grafeas.V1.Signature), global::Grafeas.V1.Signature.Parser, new[]{ "Signature_", "PublicKeyId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Kind represents the kinds of notes supported.
  /// </summary>
  public enum NoteKind {
    /// <summary>
    /// Unknown.
    /// </summary>
    [pbr::OriginalName("NOTE_KIND_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The note and occurrence represent a package vulnerability.
    /// </summary>
    [pbr::OriginalName("VULNERABILITY")] Vulnerability = 1,
    /// <summary>
    /// The note and occurrence assert build provenance.
    /// </summary>
    [pbr::OriginalName("BUILD")] Build = 2,
    /// <summary>
    /// This represents an image basis relationship.
    /// </summary>
    [pbr::OriginalName("IMAGE")] Image = 3,
    /// <summary>
    /// This represents a package installed via a package manager.
    /// </summary>
    [pbr::OriginalName("PACKAGE")] Package = 4,
    /// <summary>
    /// The note and occurrence track deployment events.
    /// </summary>
    [pbr::OriginalName("DEPLOYMENT")] Deployment = 5,
    /// <summary>
    /// The note and occurrence track the initial discovery status of a resource.
    /// </summary>
    [pbr::OriginalName("DISCOVERY")] Discovery = 6,
    /// <summary>
    /// This represents a logical "role" that can attest to artifacts.
    /// </summary>
    [pbr::OriginalName("ATTESTATION")] Attestation = 7,
    /// <summary>
    /// This represents an available package upgrade.
    /// </summary>
    [pbr::OriginalName("UPGRADE")] Upgrade = 8,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Metadata for any related URL information.
  /// </summary>
  public sealed partial class RelatedUrl : pb::IMessage<RelatedUrl> {
    private static readonly pb::MessageParser<RelatedUrl> _parser = new pb::MessageParser<RelatedUrl>(() => new RelatedUrl());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RelatedUrl> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RelatedUrl() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RelatedUrl(RelatedUrl other) : this() {
      url_ = other.url_;
      label_ = other.label_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RelatedUrl Clone() {
      return new RelatedUrl(this);
    }

    /// <summary>Field number for the "url" field.</summary>
    public const int UrlFieldNumber = 1;
    private string url_ = "";
    /// <summary>
    /// Specific URL associated with the resource.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Url {
      get { return url_; }
      set {
        url_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "label" field.</summary>
    public const int LabelFieldNumber = 2;
    private string label_ = "";
    /// <summary>
    /// Label to describe usage of the URL.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Label {
      get { return label_; }
      set {
        label_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RelatedUrl);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RelatedUrl other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Url != other.Url) return false;
      if (Label != other.Label) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Url.Length != 0) hash ^= Url.GetHashCode();
      if (Label.Length != 0) hash ^= Label.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Url.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Url);
      }
      if (Label.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Label);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Url.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Url);
      }
      if (Label.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Label);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RelatedUrl other) {
      if (other == null) {
        return;
      }
      if (other.Url.Length != 0) {
        Url = other.Url;
      }
      if (other.Label.Length != 0) {
        Label = other.Label;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Url = input.ReadString();
            break;
          }
          case 18: {
            Label = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Verifiers (e.g. Kritis implementations) MUST verify signatures
  /// with respect to the trust anchors defined in policy (e.g. a Kritis policy).
  /// Typically this means that the verifier has been configured with a map from
  /// `public_key_id` to public key material (and any required parameters, e.g.
  /// signing algorithm).
  ///
  /// In particular, verification implementations MUST NOT treat the signature
  /// `public_key_id` as anything more than a key lookup hint. The `public_key_id`
  /// DOES NOT validate or authenticate a public key; it only provides a mechanism
  /// for quickly selecting a public key ALREADY CONFIGURED on the verifier through
  /// a trusted channel. Verification implementations MUST reject signatures in any
  /// of the following circumstances:
  ///   * The `public_key_id` is not recognized by the verifier.
  ///   * The public key that `public_key_id` refers to does not verify the
  ///     signature with respect to the payload.
  ///
  /// The `signature` contents SHOULD NOT be "attached" (where the payload is
  /// included with the serialized `signature` bytes). Verifiers MUST ignore any
  /// "attached" payload and only verify signatures with respect to explicitly
  /// provided payload (e.g. a `payload` field on the proto message that holds
  /// this Signature, or the canonical serialization of the proto message that
  /// holds this signature).
  /// </summary>
  public sealed partial class Signature : pb::IMessage<Signature> {
    private static readonly pb::MessageParser<Signature> _parser = new pb::MessageParser<Signature>(() => new Signature());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Signature> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Grafeas.V1.CommonReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Signature() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Signature(Signature other) : this() {
      signature_ = other.signature_;
      publicKeyId_ = other.publicKeyId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Signature Clone() {
      return new Signature(this);
    }

    /// <summary>Field number for the "signature" field.</summary>
    public const int Signature_FieldNumber = 1;
    private pb::ByteString signature_ = pb::ByteString.Empty;
    /// <summary>
    /// The content of the signature, an opaque bytestring.
    /// The payload that this signature verifies MUST be unambiguously provided
    /// with the Signature during verification. A wrapper message might provide
    /// the payload explicitly. Alternatively, a message might have a canonical
    /// serialization that can always be unambiguously computed to derive the
    /// payload.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Signature_ {
      get { return signature_; }
      set {
        signature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "public_key_id" field.</summary>
    public const int PublicKeyIdFieldNumber = 2;
    private string publicKeyId_ = "";
    /// <summary>
    /// The identifier for the public key that verifies this signature.
    ///   * The `public_key_id` is required.
    ///   * The `public_key_id` MUST be an RFC3986 conformant URI.
    ///   * When possible, the `public_key_id` SHOULD be an immutable reference,
    ///     such as a cryptographic digest.
    ///
    /// Examples of valid `public_key_id`s:
    ///
    /// OpenPGP V4 public key fingerprint:
    ///   * "openpgp4fpr:74FAF3B861BDA0870C7B6DEF607E48D2A663AEEA"
    /// See https://www.iana.org/assignments/uri-schemes/prov/openpgp4fpr for more
    /// details on this scheme.
    ///
    /// RFC6920 digest-named SubjectPublicKeyInfo (digest of the DER
    /// serialization):
    ///   * "ni:///sha-256;cD9o9Cq6LG3jD0iKXqEi_vdjJGecm_iXkbqVoScViaU"
    ///   * "nih:///sha-256;703f68f42aba2c6de30f488a5ea122fef76324679c9bf89791ba95a1271589a5"
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PublicKeyId {
      get { return publicKeyId_; }
      set {
        publicKeyId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Signature);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Signature other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Signature_ != other.Signature_) return false;
      if (PublicKeyId != other.PublicKeyId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Signature_.Length != 0) hash ^= Signature_.GetHashCode();
      if (PublicKeyId.Length != 0) hash ^= PublicKeyId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Signature_.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(Signature_);
      }
      if (PublicKeyId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PublicKeyId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Signature_.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Signature_);
      }
      if (PublicKeyId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PublicKeyId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Signature other) {
      if (other == null) {
        return;
      }
      if (other.Signature_.Length != 0) {
        Signature_ = other.Signature_;
      }
      if (other.PublicKeyId.Length != 0) {
        PublicKeyId = other.PublicKeyId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Signature_ = input.ReadBytes();
            break;
          }
          case 18: {
            PublicKeyId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
